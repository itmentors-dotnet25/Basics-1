using System.Collections.Generic;
using System.Collections.Immutable;

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
        var words = text.Split([' ', '\t', '\n'], System.StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var word in words)
        {

            if (!string.IsNullOrWhiteSpace(word))
            {
                if (result.ContainsKey(word))
                    result[word]++;
                else
                    result.Add(word, 1);
            }
        }

        return result;
    }

    /// <summary>
    /// Задание 2.3: Напишите метод, который сортирует список строк по длине в порядке возрастания.
    /// </summary>
    public List<string> SortByLength(List<string> strings)
    {
        strings.Sort((a, b) => a.Length.CompareTo(b.Length));
        return strings;
    }

    /// <summary>
    /// Задание 2.4: Напишите метод, который возвращает все уникальные элементы из двух коллекций.
    /// </summary>
    public IEnumerable<int> GetUniqueElements(IEnumerable<int> first, IEnumerable<int> second)
    {
        var hashFirst = new HashSet<int>(first);
        var hashSecond = new HashSet<int>(second);
        hashFirst.SymmetricExceptWith(hashSecond);
        return hashFirst;
    }

    /// <summary>
    /// Задание 2.5: Напишите метод, который группирует числа по их четности.
    /// </summary>
    public Dictionary<bool, List<int>> GroupByEvenOdd(IEnumerable<int> numbers)
    {
        var groupedNumbers = numbers.GroupBy(num => num % 2 == 0);

        return groupedNumbers.ToDictionary(group => group.Key, group => group.ToList());
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
        var minValue = numbers.Min();   // Минимальное значение
        var maxValue = numbers.Max();   // Максимальное значение

        return (minValue, maxValue);
    }
}