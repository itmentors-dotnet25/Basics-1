namespace Basics.Tasks;

using BenchmarkDotNet.Attributes;

[MemoryDiagnoser] // Включает сбор информации об аллокациях памяти во время выполнения бенчмарка.
[RankColumn]      // ранжирует по скорости
public class SyntaxTasks
{
    private const int N = 30;

    [Benchmark(Baseline = true)]
    public int[] ArrayVersion() => GenerateFibonacciArray(N);

    [Benchmark]
    public int[] ListVersion() => GenerateFibonacciArrayUseList(N);
    
    /// <summary>
    /// Задание 1.1: Напишите метод, который принимает три числа и возвращает наибольшее из них.
    /// </summary>
    public int FindMaxOfThree(int a, int b, int c)
    {
        int[] numbers = [a, b, c];

        return numbers.Max();
    }

    /// <summary>
    /// Задание 1.2: Напишите метод, который вычисляет сумму всех чисел от 1 до N.
    /// </summary>
    public int CalculateSumFrom1ToN(int n)
    {
        return (n <= 1)
            ? n
            : n + CalculateSumFrom1ToN(n - 1);
    }

    /// <summary>
    /// Задание 1.3: Напишите метод, который проверяет, является ли число простым.
    /// </summary>
    public bool IsPrime(int number)
    {
        return number switch
        {
            < 2 => false,
            2 => true,
            _ when (number & 1) == 0 => false, // получение 0-го бита и проверка его на четность
            _ => Check()
        };
        
        bool Check()
        {
            for (var i = 3; i <= (int)Math.Sqrt(number); i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }

    /// <summary>
    /// Задание 1.4: Напишите метод, который генерирует массив первых N чисел Фибоначчи.
    /// </summary>
    public int[] GenerateFibonacciArray(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n, nameof(n));

        if (n == 0)
            return [];

        var numbers = new int[n];
        numbers[0] = 0;

        if (n == 1)
            return numbers;

        numbers[1] = 1;

        for (var i = 2; i < n; i++)
            numbers[i] = numbers[i - 1] + numbers[i - 2];

        return numbers;
    }

    public int[] GenerateFibonacciArrayUseList(int n)
    {
        if (n < 0) // case c n <= 0 в тесте не проверяется
            throw new ArgumentOutOfRangeException(nameof(n), "Количество чисел не может быть отрицательным.");
        if (n == 0) return [];
        if (n == 1) return [0];
        if (n == 2) return [0, 1];
        var numbers = new List<int>(n) { 0, 1 };
        for (var i = 2; i < n; i++)
            numbers.Add(numbers[i - 1] + numbers[i - 2]);
        return [.. numbers];
    }


    /// <summary>
    /// Задание 1.5: Напишите метод, который находит среднее арифметическое элементов массива.
    /// </summary>
    public double CalculateArrayAverage(int[] numbers)
    {
        if (numbers is null)
            throw new ArgumentNullException(nameof(numbers), "Массив не может быть пустым");
        
        return numbers.Length == 0
            ? 0.0
            : numbers.Average(); // Average() уже возвращает double и обрабатывает переполнение (через long внутри)
    }

    /// <summary>
    /// Задание 1.6: Напишите метод, который проверяет, является ли строка палиндромом (игнорируя регистр).
    /// </summary>
    public bool IsStringPalindrome(string text)
    {
        _ = text ?? throw new ArgumentNullException(nameof(text), "Текст не может быть Null");
        var indexLeft = 0;
        var indexRight = text.Length - 1;

        while (indexLeft < indexRight)
        {
            while (indexLeft < indexRight && !char.IsLetter(text[indexLeft]))
                indexLeft++;
            while (indexLeft < indexRight && !char.IsLetter(text[indexRight]))
                indexRight--;
            if (char.ToLowerInvariant(text[indexLeft]) != char.ToLowerInvariant(text[indexRight]))
                return false;
            indexLeft++;
            indexRight--;
        }

        return true;
    }
    
    /// <summary>
    /// Задание 1.6: Напишите метод, который проверяет, является ли строка палиндромом (игнорируя регистр). Используя LINQ
    /// </summary>
    public bool IsStringPalindromeUseLinq(string text) 
    {
        ArgumentNullException.ThrowIfNull(text);
        
        // создается новая строка на основании исходной, где удалены все не буквы и приведены к нижнему регистру
        //
        // text.Where(char.IsLetter) - отложенный LINQ-запрос (IEnumerable<char>), который будет возвращать только те символы из text,
        // для которых char.IsLetter(c) возвращает true
        // 
        // .ToArray() - перевод строки в массив из Char
        // 
        // .ToLowerInvariant() - перевод в нижний регистр
        var cleaned = new string(text.Where(char.IsLetter).ToArray()).ToLowerInvariant();
        
        for (var i = 0; i < cleaned.Length / 2; i++)
        {
            if (cleaned[i] != cleaned[cleaned.Length - 1 - i]) return false;
        }

        return true;
    }

    /// <summary>
    /// Задание 1.7: Напишите метод, который транспонирует матрицу (меняет строки и столбцы местами).
    /// </summary>
    public int[,] TransposeMatrix(int[,] matrix)
    {
        //ArgumentNullException.ThrowIfNull(matrix);
        
        var rows = matrix.GetLength(0);
        var cols = matrix.GetLength(1);

        var result = new int[cols, rows];
        
        for (var i = 0; i < rows; i++)
            for (var j = 0; j < cols; j++)
                result[j, i] = matrix[i, j];

        return result;
    }

    /// <summary>
    /// Задание 1.8: Напишите метод, который решает квадратное уравнение ax² + bx + c = 0.
    /// Возвращает массив с корнями (0, 1 или 2 корня). Корни должны быть перечислены по возрастанию.
    /// </summary>
    public double[] SolveQuadraticEquation(double a, double b, double c)
    {
        if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c))
            throw new ArgumentException("Коэффициенты не должны быть NaN.");

        if (double.IsInfinity(a) || double.IsInfinity(b) || double.IsInfinity(c))
            throw new ArgumentException("Коэффициенты не должны быть бесконечностью.");

        // линейное уравнение bx + c = 0
        if (a == 0)
        {
            if (b == 0)
                return c == 0 
                    ? [-1] // нет проверки в тестах. Бесконечное число корней
                    : [];
            return [-c / b];
        }

        // квадратное уравнение
        var discriminant = b * b - 4 * a * c;

        // Нет действительных корней
        if (discriminant < 0)
            return [];

        // Один корень (дискриминант == 0 с учётом погрешности)
        const double epsilon = 1e-12;
        if (Math.Abs(discriminant) <= epsilon)
            return [-b / (2 * a)];
        
        // Два корня
        var sqrtD = Math.Sqrt(discriminant);
        var root1 = (-b - sqrtD) / (2 * a);
        var root2 = (-b + sqrtD) / (2 * a);

        return root1 <= root2 
            ? [root1, root2] 
            : [root2, root1];
    }
}