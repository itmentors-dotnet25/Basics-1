namespace Basics.Tasks;

using System.Text.RegularExpressions;
public partial class CollectionTasks
{
    // partial - Это обязательное требование для source generator’ов в .NET:
    // Компилятор сгенерирует другую часть метода (тело),
    // Эта часть — только сигнатура + атрибут.
    // Класс тоже должен быть partial (иначе ошибка дублирования).
    //
    // Компилятор генерирует что-то вроде:
    // private static partial Regex WordRegex()
    // {
    //     // Сгенерированный высокоскоростной парсер для @"\p{L}+"
    //     return new GeneratedRegexImpl();
    // }
    [GeneratedRegex(@"\p{L}+", RegexOptions.CultureInvariant)]
    private static partial Regex WordRegex();
    
    /// <summary>
    /// Задание 2.1: Напишите метод, который фильтрует четные числа из коллекции.
    /// </summary>
    public IEnumerable<int> FilterEvenNumbers(IEnumerable<int> numbers)
    {
        return numbers.Where(number => (number & 1) == 0);
    }

    /// <summary>
    /// Задание 2.2: Напишите метод, который возвращает словарь с количеством вхождений каждого слова в строке.
    /// </summary>
    public Dictionary<string, int> CountWords(string text)
    {
        ArgumentNullException.ThrowIfNull(text);
        
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .GroupBy(word => word, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(group => group.Key, group => group.Count());
    }
    
    /// <summary>
    /// Задание 2.2: Напишите метод, который возвращает словарь с количеством вхождений каждого слова в строке,
    /// используя регулярные выражения
    /// </summary>
    public Dictionary<string, int> CountWordsUseRegEx(string text)
    {
        ArgumentNullException.ThrowIfNull(text);

        return WordRegex().Matches(text)
            .Select(m => m.Value.ToLowerInvariant())
            .GroupBy(w => w, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(g => g.Key, g => g.Count());
    }

    /// <summary>
    /// Задание 2.3: Напишите метод, который сортирует список строк по длине в порядке возрастания.
    /// </summary>
    public List<string> SortByLength(List<string> strings)
    {
        ArgumentNullException.ThrowIfNull(strings);

        // Копия string, чтобы не модифицировать исходный список
        var result = new List<string>(strings);
        result.Sort((a, b) => (a?.Length ?? 0).CompareTo(b?.Length ?? 0));
        
        return result;
    }

    /// <summary>
    /// Задание 2.4: Напишите метод, который возвращает все уникальные элементы из двух коллекций.
    /// </summary>
    public IEnumerable<int> GetUniqueElements(IEnumerable<int> first, IEnumerable<int> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        
        var firstSet = first as ICollection<int> ?? new HashSet<int>(first);
        var secondSet = second as ICollection<int> ?? new HashSet<int>(second);
        
        return firstSet.Except(secondSet).Concat(secondSet.Except(firstSet));
    }
    
    /// <summary>
    /// Задание 2.4: Напишите метод, который возвращает все уникальные элементы из двух коллекций,
    /// используя итераторы (генераторы в PHP)
    /// </summary>
    public IEnumerable<int> GetUniqueElementsUseIterator(IEnumerable<int> first, IEnumerable<int> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        
        var firstSet = new HashSet<int>(first);
        var secondSet = new HashSet<int>(second);
        var result = new List<int>();
        
        foreach (var item in first)
            if (!secondSet.Contains(item))
                result.Add(item);
        
        foreach (var item in second)
            if (!firstSet.Contains(item))
                result.Add(item);

        return result;
    }
    

    /// <summary>
    /// Задание 2.5: Напишите метод, который группирует числа по их четности.
    /// </summary>
    public Dictionary<bool, List<int>> GroupByEvenOdd(IEnumerable<int> numbers)
    {
        ArgumentNullException.ThrowIfNull(numbers);
        
       return numbers
           .GroupBy(item => (item & 1) == 0)
           .ToDictionary(group => group.Key, group => group.ToList());
    }

    /// <summary>
    /// Задание 2.6: Напишите метод, который проверяет, все ли элементы коллекции удовлетворяют условию.
    /// </summary>
    public bool AllElementsSatisfyCondition(IEnumerable<int> numbers, Func<int, bool> predicate)
    {
        ArgumentNullException.ThrowIfNull(numbers);
        ArgumentNullException.ThrowIfNull(predicate);

        return numbers.All(predicate);
    }

    /// <summary>
    /// Задание 2.7: Напишите метод, который возвращает первые N элементов коллекции.
    /// </summary>
    public IEnumerable<int> TakeFirstNElements(IEnumerable<int> numbers, int n)
    {
        ArgumentNullException.ThrowIfNull(numbers);

        return numbers.Take(n);
    }

    /// <summary>
    /// Задание 2.8: Напишите метод, который возвращает минимальный и максимальный элементы коллекции.
    /// </summary>
    public (int min, int max) FindMinMax(IEnumerable<int> numbers)
    {
        ArgumentNullException.ThrowIfNull(numbers);

        return (numbers.Min(), numbers.Max());
    }
}