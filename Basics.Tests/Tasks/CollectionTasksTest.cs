using Basics.Tasks;
using Xunit;

namespace Basics.Test.Tasks;

public class CollectionTasksTests
{
    private readonly CollectionTasks _collectionTasks = new();

    [Fact]
    public void FilterEvenNumbers_ShouldReturnOnlyEvenNumbers()
    {
        // Arrange
        var numbers = new[] { 1, 2, 3, 4, 5, 6 };

        // Act
        var result = _collectionTasks.FilterEvenNumbers(numbers);

        // Assert
        Assert.Equal(new[] { 2, 4, 6 }, result);
    }

    [Fact]
    public void CountWords_ShouldReturnCorrectWordCounts()
    {
        // Arrange
        var text = "hello world hello test";

        // Act
        var result = _collectionTasks.CountWords(text);

        // Assert
        Assert.Equal(2, result["hello"]);
        Assert.Equal(1, result["world"]);
        Assert.Equal(1, result["test"]);
    }
    
    [Fact]
    public void CountWordsUseRegEx_ShouldReturnCorrectWordCounts()
    {
        // Arrange
        var text = "Hello, world hello-test";

        // Act
        var result = _collectionTasks.CountWordsUseRegEx(text);

        // Assert
        Assert.Equal(2, result["hello"]);
        Assert.Equal(1, result["world"]);
        Assert.Equal(1, result["test"]);
    }

    [Fact]
    public void SortByLength_ShouldSortStringsByLength()
    {
        // Arrange
        var strings = new List<string> { "longword", "medium", "a" };

        // Act
        var result = _collectionTasks.SortByLength(strings);

        // Assert
        Assert.Equal(new[] { "a", "medium", "longword" }, result);
    }

    [Fact]
    public void GetUniqueElements_ShouldReturnUniqueElementsFromBothCollections()
    {
        // Arrange
        var first = new[] { 1, 2, 3, 4 };
        var second = new[] { 3, 4, 5, 6 };

        // Act
        var result = _collectionTasks.GetUniqueElements(first, second);

        // Assert
        Assert.Equal(new[] { 1, 2, 5, 6 }, result.OrderBy(x => x));
    }
    
    [Fact]
    public void GetUniqueElementsUseIterator_ShouldReturnUniqueElementsFromBothCollections()
    {
        // Arrange
        var first = new[] { 1, 2, 3, 4, 4 };
        var second = new[] { 3, 4, 5, 6 };

        // Act
        var result = _collectionTasks.GetUniqueElementsUseIterator(first, second);

        // Assert
        Assert.Equal(new[] { 1, 2, 5, 6 }, result.OrderBy(x => x));
    }

    [Fact]
    public void GroupByEvenOdd_ShouldGroupNumbersCorrectly()
    {
        // Arrange
        var numbers = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = _collectionTasks.GroupByEvenOdd(numbers);

        // Assert
        Assert.Equal(new[] { 2, 4 }, result[true]);
        Assert.Equal(new[] { 1, 3, 5 }, result[false]);
    }


    [Theory]
    [InlineData(new[] { 2, 4, 6, 8 }, true)]
    [InlineData(new[] { 2, 4, 5, 8 }, false)]
    [InlineData(new[] { 1, 3, 5, 7 }, false)]
    [InlineData(new int[0], true)]
    public void AllElementsSatisfyCondition_ShouldReturnCorrectResult(int[] numbers, bool expected)
    {
        // Arrange
        bool IsEven(int n) => n % 2 == 0;

        // Act
        var result = _collectionTasks.AllElementsSatisfyCondition(numbers, IsEven);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void AllElementsSatisfyCondition_ShouldWorkWithDifferentPredicates()
    {
        // Arrange
        var numbers = new[] { 10, 20, 30, 40 };
        bool IsGreaterThanFive(int n) => n > 5;

        // Act
        var result = _collectionTasks.AllElementsSatisfyCondition(numbers, IsGreaterThanFive);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0, new int[0])]
    [InlineData(2, new[] { 1, 2 })]
    [InlineData(5, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(10, new[] { 1, 2, 3, 4, 5 })]
    public void TakeFirstNElements_ShouldTakeCorrectNumberOfElements(int n, int[] expected)
    {
        // Arrange
        var numbers = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = _collectionTasks.TakeFirstNElements(numbers, n);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindMinMax_ShouldReturnCorrectMinAndMax()
    {
        // Arrange
        var numbers = new[] { 5, 2, 8, 1, 9, 3 };

        // Act
        var result = _collectionTasks.FindMinMax(numbers);

        // Assert
        Assert.Equal(1, result.min);
        Assert.Equal(9, result.max);
    }

    [Fact]
    public void FindMinMax_ShouldHandleSingleElement()
    {
        // Arrange
        var numbers = new[] { 42 };

        // Act
        var result = _collectionTasks.FindMinMax(numbers);

        // Assert
        Assert.Equal(42, result.min);
        Assert.Equal(42, result.max);
    }

    [Fact]
    public void FindMinMax_ShouldHandleNegativeNumbers()
    {
        // Arrange
        var numbers = new[] { -5, -2, -8, -1 };

        // Act
        var result = _collectionTasks.FindMinMax(numbers);

        // Assert
        Assert.Equal(-8, result.min);
        Assert.Equal(-1, result.max);
    }
}