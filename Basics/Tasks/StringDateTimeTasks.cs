using System.Text;

namespace Basics.Tasks;

public class StringDateTimeTasks
{
    /// <summary>
    /// Задание 5.1: Напишите метод, который возвращает строку в обратном порядке.
    /// </summary>
    public string ReverseString(string input)
    {
        return new string(input.Reverse().ToArray());
    }

    /// <summary>
    /// Задание 5.2: Напишите метод, который проверяет, является ли строка палиндромом.
    /// </summary>
    public bool IsPalindrome(string input)
    {
       return new SyntaxTasks().IsStringPalindromeUseLinq(input);
    }

    /// <summary>
    /// Задание 5.3: Напишите метод, который объединяет массив строк в одну строку с использованием StringBuilder.
    /// </summary>
    public string ConcatenateStrings(string[] strings)
    {
        var sb = new StringBuilder();
        
        foreach (var str in strings)
        {
            sb.Append(str);
        }
        
        return sb.ToString();
    }

    /// <summary>
    /// Задание 5.4: Напишите метод, который вычисляет возраст по дате рождения.
    /// </summary>
    public int CalculateAge(DateTime birthDate)
    {
        var today = DateTime.Now;
        var birthDateYear = birthDate.Year;
        
        return birthDateYear > today.Year
            ? 0
            : today.Year - birthDateYear;
    }

    /// <summary>
    /// Задание 5.5: Напишите метод, который возвращает разницу между двумя датами в днях.
    /// </summary>
    public int GetDaysDifference(DateTime first, DateTime second)
    {
        return Math.Abs((second.Date - first.Date).Days);
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
            return Array.Empty<string>();
        // Возврат ответа на null вместо исключения ArgumentNullException.ThrowIfNull(text);
        // зависит от контекста. Здесь допустил получение null - как нормальное поведение.

        return text.Split(
            [' ', '\t', '\n', '\r'],
            StringSplitOptions.RemoveEmptyEntries
        );
    }

    /// <summary>
    /// Задание 5.8: Напишите метод, который проверяет, начинается ли строка с определенной подстроки.
    /// </summary>
    public bool StartsWithSubstring(string text, string substring)
    {
        ArgumentNullException.ThrowIfNull(text, nameof(text));
        
        return text.StartsWith(substring, StringComparison.CurrentCulture);
    }

    /// <summary>
    /// Задание 5.9: Напишите метод, который удаляет все пробелы из строки.
    /// </summary>
    public string RemoveSpaces(string text)
    {
        ArgumentNullException.ThrowIfNull(text, nameof(text));
        
        return text.Replace(" ", "");
    }

    /// <summary>
    /// Задание 5.10: Напишите метод, который повторяет строку N раз с использованием StringBuilder.
    /// </summary>
    public string RepeatString(string text, int count)
    {
        ArgumentNullException.ThrowIfNull(text, nameof(text));
        
        var sb = new StringBuilder();

        for (var i = 0; i < count; i++)
            sb.Append(text);
        
        return sb.ToString();
    }

    /// <summary>
    /// Задание 5.11: Напишите метод, который находит разницу во времени между двумя DateTime в часах и минутах.
    /// Возвращает кортеж (hours, minutes).
    /// </summary>
    public (int hours, int minutes) GetTimeDifference(DateTime first, DateTime second)
    {
        var diff = first - second;
        
        return (
            Math.Abs(diff.Hours),
            Math.Abs(diff.Minutes)
        );
    }

    /// <summary>
    /// Задание 5.12: Напишите метод, который преобразует строку в верхний регистр с использованием String.ToUpper.
    /// </summary>
    public string ConvertToUpper(string text)
    {
        ArgumentNullException.ThrowIfNull(text, nameof(text));
        
        return text.ToUpper();
    }
}