// See https://aka.ms/new-console-template for more information
using Basics.Tasks;
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");

var wordCounts = new CollectionTasks().CountWordsUseRegEx("Hello, World!");
string[] str = { string.Join(", ", wordCounts) };
Console.WriteLine($"[{string.Join(", ", wordCounts)}]"); // Просто так Dictionary не вывести

var first = new[] { 1, 1, 2, 3, 4 };
var second = new[] { 3, 4, 5, 6 };
bool IsEven(int n) => n % 2 == 0;
var s = new CollectionTasks().AllElementsSatisfyCondition(new[] { 2, 4, 5, 8 }, IsEven);
Console.WriteLine($"[{string.Join(", ", s)}]");

// Обоснование использования проверки на null входных параметров
// В рамках задания 1.1 не требуется. Нет ни одного теста на проверку.
try
{
    Console.WriteLine(new SyntaxTasks().TransposeMatrix(null!));
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
    Console.WriteLine($"Параметр: {ex.ParamName}");
    
    // Условно была передана модель Account. 
    // Метод SendAccount(Account personFirstAccount) принимает эту модель. Null не ожидалась
    // тогда здесь можно логировать с account_id, calc_center_id и т.д.
}
catch (Exception ex)
{
    Console.WriteLine($"КРИТИЧЕСКАЯ ОШИБКА: {ex.GetType().Name}");
    Console.WriteLine($"message: {ex.Message}");
    Console.WriteLine("Причина: не хватает проверки на null в TransposeMatrix.");
    // Такое исключение — сигнал о баге в коде, а не о некорректной передачи.
}

// Запуск бенчмарка для сравнения методов
// GenerateFibonacciArray и GenerateFibonacciArrayUseList
// BenchmarkRunner.Run<SyntaxTasks>();

// | Method       | Mean     | Error    | StdDev   | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
// |------------- |---------:|---------:|---------:|------:|--------:|-----:|-------:|----------:|------------:|
// | ArrayVersion | 29.69 ns | 0.624 ns | 0.874 ns |  1.00 |    0.04 |    1 | 0.0114 |     144 B |        1.00 |
// | ListVersion  | 58.41 ns | 0.916 ns | 0.857 ns |  1.97 |    0.06 |    2 | 0.0254 |     320 B |        2.22 |
//
// Вывод: Использование коллекций удобно - но дороже в 2 раза.