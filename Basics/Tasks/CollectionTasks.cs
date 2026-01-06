using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Basics.Tasks;

public class CollectionTasks
{
    /// <summary>
    /// Задание 2.1: Напишите метод, который фильтрует четные числа из коллекции.
    /// </summary>
    public static IEnumerable<int> FilterEvenNumbers(IEnumerable<int> numbers)
    {
        return numbers.Where(x => x % 2 == 0);
    }

    /// <summary>
    /// Задание 2.2: Напишите метод, который возвращает словарь с количеством вхождений каждого слова в строке.
    /// </summary>
    public Dictionary<string, int> CountWords(string text)
    {
        return text
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .GroupBy(x => x)
            .ToDictionary(group => group.Key, group => group.Count());
    }

    /// <summary>
    /// Задание 2.3: Напишите метод, который сортирует список строк по длине в порядке возрастания.
    /// </summary>
    public static List<string> SortByLength(List<string> strings)
    {
        return strings
            .OrderBy(x => x.Length)
            .ToList();
    }

    /// <summary>
    /// Задание 2.4: Напишите метод, который возвращает все уникальные элементы из двух коллекций.
    /// </summary>
    public static IEnumerable<int> GetUniqueElements(IEnumerable<int> first, IEnumerable<int> second)
    {
        var onlyFirst = first.Except(second);
        var onlySecond = second.Except(first);
        return onlyFirst.Union(onlySecond); 
    }

    /// <summary>
    /// Задание 2.5: Напишите метод, который группирует числа по их четности.
    /// </summary>
    public Dictionary<bool, List<int>> GroupByEvenOdd(IEnumerable<int> numbers)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задание 2.6: Напишите метод, который проверяет, все ли элементы коллекции удовлетворяют условию.
    /// </summary>
    public bool AllElementsSatisfyCondition(IEnumerable<int> numbers, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
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

        var list = numbers.ToList();

        int min = list.Min();
        int max = list.Max();
        return (min, max);
    }
}