using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Basics.Tasks;

public class StringDateTimeTasks
{
    /// <summary>
    /// Задание 5.1: Напишите метод, который возвращает строку в обратном порядке.
    /// </summary>
    public string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        char[] reverseString = input.ToCharArray();
        Array.Reverse(reverseString);
        return new String(reverseString);
    }

    /// <summary>
    /// Задание 5.2: Напишите метод, который проверяет, является ли строка палиндромом.
    /// </summary>
    /// Было в задании 1.6
    public bool IsPalindrome(string input)
    {
        if (input == "") return true;
        input = Regex.Replace(input.ToLower().Trim(), @"\s+", "");
        int count = input.Length;
        foreach (char ch in input)
        {
            count--;
            if (ch == input[count]) continue; else return false;
        }
        return true;
    }

    /// <summary>
    /// Задание 5.3: Напишите метод, который объединяет массив строк в одну строку с использованием StringBuilder.
    /// </summary>
    public string ConcatenateStrings(string[] strings)
    {
        StringBuilder result = new StringBuilder();
        foreach (var word in strings)
        {
            result.Append(word);
        }
        return result.ToString();
    }

    /// <summary>
    /// Задание 5.4: Напишите метод, который вычисляет возраст по дате рождения.
    /// </summary>
    public int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Today;
        return today.Year - birthDate.Year;
    }

    /// <summary>
    /// Задание 5.5: Напишите метод, который возвращает разницу между двумя датами в днях.
    /// </summary>
    public int GetDaysDifference(DateTime first, DateTime second)
    {
        return (int)(second - first).TotalDays;
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
        if (string.IsNullOrEmpty(text)) return new string[0];
        return text.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    }

    /// <summary>
    /// Задание 5.8: Напишите метод, который проверяет, начинается ли строка с определенной подстроки.
    /// </summary>
    public bool StartsWithSubstring(string text, string substring)
    {
        if (string.IsNullOrEmpty(text)) return true;
        if (string.IsNullOrWhiteSpace(text)) return false;
        if (string.IsNullOrWhiteSpace(substring)) return true;

        return text.StartsWith(substring);
    }

    /// <summary>
    /// Задание 5.9: Напишите метод, который удаляет все пробелы из строки.
    /// </summary>
    public string RemoveSpaces(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        return text.Replace(" ", "");
    }

    /// <summary>
    /// Задание 5.10: Напишите метод, который повторяет строку N раз с использованием StringBuilder.
    /// </summary>
    public string RepeatString(string text, int count)
    {
        if (count <= 0 || string.IsNullOrEmpty(text)) return "";

        StringBuilder result = new StringBuilder();

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
    public (int hours, int minutes) GetTimeDifference(DateTime first, DateTime second)
    {
        return (Math.Abs((second - first).Hours), Math.Abs((second - first).Minutes));
    }

    /// <summary>
    /// Задание 5.12: Напишите метод, который преобразует строку в верхний регистр с использованием String.ToUpper.
    /// </summary>
    public string ConvertToUpper(string text)
    {
        StringBuilder result = new StringBuilder(text);
        return result.ToString().ToUpper();
    }
}