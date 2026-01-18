using System.Text;

namespace Basics.Tasks;

public class StringDateTimeTasks
{
    /// <summary>
    /// Задание 5.1: Напишите метод, который возвращает строку в обратном порядке.
    /// </summary>
    public static string ReverseString(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new String(chars);
    }

    /// <summary>
    /// Задание 5.2: Напишите метод, который проверяет, является ли строка палиндромом.
    /// </summary>
    public static bool IsPalindrome(string input)
    {
        string teststring = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        int start = 0;
        int finish = teststring.Length - 1;
        while (start < finish)
        {
            if (teststring[start] != teststring[finish])
            {
                return false;
            }
            start++;
            finish--;
        }

        return true;

    }

    /// <summary>
    /// Задание 5.3: Напишите метод, который объединяет массив строк в одну строку с использованием StringBuilder.
    /// </summary>
    public static string ConcatenateStrings(string[] strings)
    {
        var concatstring = new StringBuilder();
        foreach (string s in strings)
        {
            concatstring.Append(s);
        }
        return concatstring.ToString();
    }

    /// <summary>
    /// Задание 5.4: Напишите метод, который вычисляет возраст по дате рождения.
    /// </summary>
    public static int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Today;

        int age = today.Year - birthDate.Year;
        if (DateTime.Today < birthDate.AddYears(age))
            age--;

        return age;

    }

    /// <summary>
    /// Задание 5.5: Напишите метод, который возвращает разницу между двумя датами в днях.
    /// </summary>
    public static int GetDaysDifference(DateTime first, DateTime second)
    {
        return (second.Date - first.Date).Days;
    }

    /// <summary>
    /// Задание 5.6: Напишите метод, который форматирует дату в строку формата dd.MM.yyyy .
    /// </summary>
    public static string FormatDate(DateTime date)
    {
        return date.ToString("dd.MM.yyyy");
    }

    /// <summary>
    /// Задание 5.7: Напишите метод, который разделяет строку на слова и возвращает массив слов.
    /// </summary>
    public static string[] SplitIntoWords(string text)
    {
        if (string.IsNullOrEmpty(text))
            return Array.Empty<string>();
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }

    /// <summary>
    /// Задание 5.8: Напишите метод, который проверяет, начинается ли строка с определенной подстроки.
    /// </summary>
    public static bool StartsWithSubstring(string text, string substring)
    {
        if (text is null || substring is null) return false;
        return text.StartsWith(substring, StringComparison.Ordinal);
    }

    /// <summary>
    /// Задание 5.9: Напишите метод, который удаляет все пробелы из строки.
    /// </summary>
    public static string RemoveSpaces(string text)
    {
        var result = new StringBuilder();
        foreach (char c in text)
        {
            if (!char.IsWhiteSpace(c))
                result.Append(c);
        }
        return result.ToString();
    }

    /// <summary>
    /// Задание 5.10: Напишите метод, который повторяет строку N раз с использованием StringBuilder.
    /// </summary>
    public static string RepeatString(string text, int count)
    {
        var result = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            result.Append(text);
        }
        return result.ToString();
    }

    /// <summary>
    /// Задание 5.11: Напишите метод, который находит разницу во времени между двумя DateTime в часах и минутах.
    /// Возвращает кортеж (hours, minutes).
    /// </summary>
    public static (int hours, int minutes) GetTimeDifference(DateTime first, DateTime second)
    {
        TimeSpan result = second - first;
        int h = result.Hours;
        int m = result.Minutes;
        if (h < 0 || m < 0) 
        { 
            h = -h; 
            m = -m;
        }
        return (h, m);

    }
    

    /// <summary>
    /// Задание 5.12: Напишите метод, который преобразует строку в верхний регистр с использованием String.ToUpper.
    /// </summary>
    public static string ConvertToUpper(string text)
    {
        return text.ToUpper();
    }
}