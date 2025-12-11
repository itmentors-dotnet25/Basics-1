using System.Text.RegularExpressions;

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
        int res = 0;
        for(int i =0; i<=n; i++) {
            res += i;
        }
        return res;
    }

    /// <summary>
    /// Задание 1.3: Напишите метод, который проверяет, является ли число простым.
    /// </summary>
    public bool IsPrime(int number)
    {
        if (number <= 1 || number == 4) return false;
        for (int i = 3; i < number; i += 2)
        {
            if (number % i == 0) return false;
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
            return Array.Empty<int>();
        }

        int[] fibNumbers = new int[n];
        fibNumbers[0] = 0;
        if (n > 1) fibNumbers[1] = 1;

        for (int i = 2; i<n; i++ )
        {
            fibNumbers[i] = fibNumbers[i - 1] + fibNumbers[i - 2];
        }

        return fibNumbers;
    }

    /// <summary>
    /// Задание 1.5: Напишите метод, который находит среднее арифметическое элементов массива.
    /// </summary>
    public double CalculateArrayAverage(int[] numbers)
    {

        int summa = 0;
        foreach (int n in numbers)
        {
            summa += n;
        }

        if (summa == 0) return 0.0;

        return summa/numbers.Length;
    }

    /// <summary>
    /// Задание 1.6: Напишите метод, который проверяет, является ли строка палиндромом (игнорируя регистр).
    /// </summary>
    public bool IsStringPalindrome(string text)
    {
        if (text == "") return true; 
        text = Regex.Replace(text.ToLower().Trim(), @"\s+", "");
        int count = text.Length;
        foreach (char ch in text)
        {
            count--;
            if (ch == text[count]) continue; else return false;
        }
        return true;
    }

    /// <summary>
    /// Задание 1.7: Напишите метод, который транспонирует матрицу (меняет строки и столбцы местами).
    /// </summary>
    public int[,] TransposeMatrix(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        int[,] result = new int[col, row];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }

    /// <summary>
    /// Задание 1.8: Напишите метод, который решает квадратное уравнение ax² + bx + c = 0.
    /// Возвращает массив с корнями (0, 1 или 2 корня). Корни должны быть перечислены по возрастанию.
    /// </summary>
    public double[] SolveQuadraticEquation(double a, double b, double c)
    {
        if (Math.Abs(a) < 1e-10)
        {
            if (Math.Abs(b) < 1e-10)
                return Math.Abs(c) < 1e-10 ? new double[] { 0 } : Array.Empty<double>();

            return new double[] { -c / b };
        }



        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
            return Array.Empty<double>();

        if (discriminant == 0)
            return new double[] { -b / (2 * a) };

        double sqrtDiscr = Math.Sqrt(discriminant);
        double root1 = (-b - sqrtDiscr) / (2 * a);
        double root2 = (-b + sqrtDiscr) / (2 * a);

        return new double[] { Math.Min(root1, root2), Math.Max(root1, root2) };
    }

}