namespace Basics.Tasks;

public class CollectionTasks
{
    /// <summary>
    /// Задание 2.1: Напишите метод, который фильтрует четные числа из коллекции.
    /// </summary>
    public IEnumerable<int> FilterEvenNumbers(IEnumerable<int> numbers)
    {
        return numbers.Where(n => n % 2 == 0);
    }

    /// <summary>
    /// Задание 2.2: Напишите метод, который возвращает словарь с количеством вхождений каждого слова в строке.
    /// </summary>
    public Dictionary<string, int> CountWords(string text)
    {
        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var result = new Dictionary<string, int>();
        // var result = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase); // регистронезависимость 

        foreach (string word in words)
        {
            result[word] = result.GetValueOrDefault(word) + 1;
        }

        return result;
    }

    /// <summary>
    /// Задание 2.3: Напишите метод, который сортирует список строк по длине в порядке возрастания.
    /// </summary>
    public List<string> SortByLength(List<string> strings)
    {
        return strings.OrderBy(s => s?.Length).ToList();
    }

    /// <summary>
    /// Задание 2.4: Напишите метод, который возвращает все уникальные элементы из двух коллекций.
    /// </summary>
    public IEnumerable<int> GetUniqueElements(IEnumerable<int> first, IEnumerable<int> second)
    {
        var set1 = new HashSet<int>(first);
        var set2 = new HashSet<int>(second);

        return set1.Except(set2).Concat(set2.Except(set1));
    }

    /// <summary>
    /// Задание 2.5: Напишите метод, который группирует числа по их четности.
    /// </summary>
    public Dictionary<bool, List<int>> GroupByEvenOdd(IEnumerable<int> numbers)
    {
        var result = new Dictionary<bool, List<int>>
        {
            { true, new List<int>() },
            { false, new List<int>() }
        };

        foreach (int number in numbers)
        {
            bool isEven = number % 2 == 0;
            result[isEven].Add(number);
        }

        return result;
    }

    /// <summary>
    /// Задание 2.6: Напишите метод, который проверяет, все ли элементы коллекции удовлетворяют условию.
    /// </summary>
    public bool AllElementsSatisfyCondition(IEnumerable<int> numbers, Func<int, bool> predicate)
    {
        return numbers.All(predicate);
    }

    /// <summary>
    /// Задание 2.7: Напишите метод, который возвращает первые N элементов коллекции.
    /// </summary>
    public IEnumerable<int> TakeFirstNElements(IEnumerable<int> numbers, int n)
    {
        return numbers.Take(n);
    }

    /// <summary>
    /// Задание 2.8: Напишите метод, который возвращает минимальный и максимальный элементы коллекции.
    /// </summary>
    public (int min, int max) FindMinMax(IEnumerable<int> numbers)
    {
        var enumerable = numbers as int[] ?? numbers.ToArray();

        return (enumerable.Min(), enumerable.Max());
    }
}