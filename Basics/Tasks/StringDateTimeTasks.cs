using System.Text;

namespace Basics.Tasks;

public class StringDateTimeTasks
{
    /// <summary>
    /// Задание 5.1: Напишите метод, который возвращает строку в обратном порядке.
    /// </summary>
    public string ReverseString(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);

        return new string(chars);
    }

    /// <summary>
    /// Задание 5.2: Напишите метод, который проверяет, является ли строка палиндромом.
    /// </summary>
    public bool IsPalindrome(string input)
    {
        var clean = new StringBuilder();
        
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                clean.Append(char.ToLower(c));
            }
        }

        return IsMirrorString(clean.ToString());
    }

    private bool IsMirrorString(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left++] != s[right--])
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Задание 5.3: Напишите метод, который объединяет массив строк в одну строку с использованием StringBuilder.
    /// </summary>
    public string ConcatenateStrings(string[] strings)
    {
        var sb = new StringBuilder();

        foreach (string s in strings)
        {
            if (s != null)
            {
                sb.Append(s);
            }
        }

        return sb.ToString();
    }

    /// <summary>
    /// Задание 5.4: Напишите метод, который вычисляет возраст по дате рождения.
    /// </summary>
    public int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Today;

        int age = today.Year - birthDate.Year;

        if (birthDate.Date > today.AddYears(-age))
        {
            age--;
        }

        return age;
    }

    /// <summary>
    /// Задание 5.5: Напишите метод, который возвращает разницу между двумя датами в днях.
    /// </summary>
    public int GetDaysDifference(DateTime first, DateTime second)
    {
        return Math.Abs((first - second).Days);
    }

    /// <summary>
    /// Задание 5.6: Напишите метод, который форматирует дату в строку формата dd.MM.yyyy .
    /// </summary>
    public string FormatDate(DateTime date)
    {
        return date.ToString("dd.MM.yyyy");
    }

    /// <summary>
    /// Задание 5.7: Напишите метод, который разделяет строку на слова и возвращает массив слов.
    /// </summary>
    public string[] SplitIntoWords(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return new string[0];
        }

        char[] separators = { ' ' }; // '\t', '\n', '\r' ??

        return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    }

    /// <summary>
    /// Задание 5.8: Напишите метод, который проверяет, начинается ли строка с определенной подстроки.
    /// </summary>
    public bool StartsWithSubstring(string text, string substring)
    {
        if (text == null || substring == null)
        {
            return false;
        }

        return text.StartsWith(substring);
    }

    /// <summary>
    /// Задание 5.9: Напишите метод, который удаляет все пробелы из строки.
    /// </summary>
    public string RemoveSpaces(string text)
    {
        return text.Replace(" ", "");
    }

    /// <summary>
    /// Задание 5.10: Напишите метод, который повторяет строку N раз с использованием StringBuilder.
    /// </summary>
    public string RepeatString(string text, int count)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            sb.Append(text);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Задание 5.11: Напишите метод, который находит разницу во времени между двумя DateTime в часах и минутах.
    /// Возвращает кортеж (hours, minutes).
    /// </summary>
    public (int hours, int minutes) GetTimeDifference(DateTime first, DateTime second)
    {
        TimeSpan diff = first > second
            ? first - second
            : second - first;

        return ((int)diff.TotalHours, diff.Minutes);
    }

    /// <summary>
    /// Задание 5.12: Напишите метод, который преобразует строку в верхний регистр с использованием String.ToUpper.
    /// </summary>
    public string ConvertToUpper(string text)
    {
        return text.ToUpper();
    }
}