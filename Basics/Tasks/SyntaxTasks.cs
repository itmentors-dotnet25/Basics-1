using System.Formats.Tar;

namespace Basics.Tasks;

public class SyntaxTasks
{
    /// <summary>
    /// Задание 1.1: Напишите метод, который принимает три числа и возвращает наибольшее из них.
    /// </summary>
    public static int FindMaxOfThree(int a, int b, int c)
    {
        int max = c;

        if (b > max)
            max = b;
        if (a > max)
            max = a;
        return max;        
    }

    /// <summary>
    /// Задание 1.2: Напишите метод, который вычисляет сумму всех чисел от 1 до N.
    /// </summary>
    public static int CalculateSumFrom1ToN(int n)
    {
        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            result += i;
        }
        return result;        
    }

    /// <summary>
    /// Задание 1.3: Напишите метод, который проверяет, является ли число простым.
    /// </summary>
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false; 
        if (number == 2) return true; 
        if (number % 2 == 0) return false; // четное, не простое
        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    /// <summary>
    /// Задание 1.4: Напишите метод, который генерирует массив первых N чисел Фибоначчи.
    /// </summary>
    public static int[] GenerateFibonacciArray(int n)
    {
        if (n <= 0) return new int[0];
        int[] fibo = new int[n];
        if (n >= 1) fibo[0] = 0;
        if (n >= 2) fibo[1] = 1;
        for (int i = 2; i < n; i++) fibo[i] = fibo[i-2] + fibo[i-1];
        return fibo;

    }

    /// <summary>
    /// Задание 1.5: Напишите метод, который находит среднее арифметическое элементов массива.
    /// </summary>
    public static double CalculateArrayAverage(int[] numbers)
    {
        double result = 0;
        if (numbers == null || numbers.Length == 0)
        {
            return result;   
        }
        
                foreach (int n in numbers)
        {
            result += n;
        }
        return result / numbers.Length;
    }

    /// <summary>
    /// Задание 1.6: Напишите метод, который проверяет, является ли строка палиндромом (игнорируя регистр).
    /// </summary>
    public static bool IsStringPalindrome(string text)
    {
        text = text.ToLowerInvariant();

        for (int left = 0, right = text.Length - 1; left < right; left++, right--)
        {
            while (left < right && !char.IsLetterOrDigit(text[left]))
                left++;
            while (left < right && !char.IsLetterOrDigit(text[right]))
                right--;
            if (text[left] != text[right]) return false;
        }
        return true;
    }

    /// <summary>
    /// Задание 1.7: Напишите метод, который транспонирует матрицу (меняет строки и столбцы местами).
    /// </summary>
    public int[,] TransposeMatrix(int[,] matrix)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задание 1.8: Напишите метод, который решает квадратное уравнение ax² + bx + c = 0.
    /// Возвращает массив с корнями (0, 1 или 2 корня). Корни должны быть перечислены по возрастанию.
    /// </summary>
    public double[] SolveQuadraticEquation(double a, double b, double c)
    {
        throw new NotImplementedException();
    }
    
}