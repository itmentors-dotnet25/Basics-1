namespace Basics.Tasks;

public class CollectionTasks
{
    /// <summary>
    /// Задание 2.1: Напишите метод, который фильтрует четные числа из коллекции.
    /// </summary>
    public IEnumerable<int> FilterEvenNumbers(IEnumerable<int> numbers)
    {
        var result = new List<int>();
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                result.Add(number);
            }
        }

        return result;
    }

    /// <summary>
    /// Задание 2.2: Напишите метод, который возвращает словарь с количеством вхождений каждого слова в строке.
    /// </summary>
    public Dictionary<string, int> CountWords(string text)
    {
        var wordCounts = new Dictionary<string, int>();

        if (string.IsNullOrEmpty(text))
        {
            return wordCounts;
        }

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            if (string.IsNullOrEmpty(word))
            {
                continue;
            }

            string key = word.ToLower();

            if (wordCounts.ContainsKey(key))
            {
                wordCounts[key]++;
            }
            else
            {
                wordCounts[key] = 1;
            }
        }

        return wordCounts;
    }

    /// <summary>
    /// Задание 2.3: Напишите метод, который сортирует список строк по длине в порядке возрастания.
    /// </summary>
    public List<string> SortByLength(List<string> strings)
    {
        var result = new List<string>(strings);
        result.Sort((a, b) => a.Length.CompareTo(b.Length));
        return result;
    }

    /// <summary>
    /// Задание 2.4: Напишите метод, который возвращает все уникальные элементы из двух коллекций.
    /// </summary>
    public IEnumerable<int> GetUniqueElements(IEnumerable<int> first, IEnumerable<int> second)
    {
        var set1 = new HashSet<int>(first);
        var set2 = new HashSet<int>(second);
        var result = new List<int>();

        foreach (var item in set1)
        {
            if (!set2.Contains(item))
            {
                result.Add(item);
            }
        }

        foreach (var item in set2)
        {
            if (!set1.Contains(item))
            {
                result.Add(item);
            }
        }

        return result;
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
            result[number % 2 == 0].Add(number);
        }

        return result;
    }

    /// <summary>
    /// Задание 2.6: Напишите метод, который проверяет, все ли элементы коллекции удовлетворяют условию.
    /// </summary>
    public bool AllElementsSatisfyCondition(IEnumerable<int> numbers, Func<int, bool> predicate)
    {
        // if (predicate == null)
        // {
        //     throw new ArgumentNullException(nameof(predicate));
        // }

        foreach (int number in numbers)
        {
            if (!predicate(number))
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Задание 2.7: Напишите метод, который возвращает первые N элементов коллекции.
    /// </summary>
    public IEnumerable<int> TakeFirstNElements(IEnumerable<int> numbers, int n)
    {
        var result = new List<int>();
        int count = 0;

        foreach (int number in numbers)
        {
            if (count >= n)
            {
                break;
            }

            result.Add(number);
            count++;
        }

        return result;
    }

    /// <summary>
    /// Задание 2.8: Напишите метод, который возвращает минимальный и максимальный элементы коллекции.
    /// </summary>
    public (int min, int max) FindMinMax(IEnumerable<int> numbers)
    {
        return (numbers.Min(), numbers.Max());
    }
}