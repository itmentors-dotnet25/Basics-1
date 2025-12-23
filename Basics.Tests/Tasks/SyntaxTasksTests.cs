using Basics.Tasks;
using Xunit;

namespace Basics.Test.Tasks;

public class SyntaxTasksTests
{
    private readonly SyntaxTasks _syntaxTasks = new();

    [Theory]
    [InlineData(1, 2, 3, 3)]
    [InlineData(10, 5, 8, 10)]
    [InlineData(-1, -5, -3, -1)]
    [InlineData(0, 0, 0, 0)]
    [InlineData(7, 7, 5, 7)]
    public void FindMaxOfThree_ShouldReturnLargestNumber(int a, int b, int c, int expected)
    {
        // Act
        var result = SyntaxTasks.FindMaxOfThree(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(5, 15)] // 1+2+3+4+5 = 15
    [InlineData(10, 55)]
    [InlineData(0, 0)]
    [InlineData(100, 5050)]
    public void CalculateSumFrom1ToN_ShouldReturnCorrectSum(int n, int expected)
    {
        // Act
        var result = SyntaxTasks.CalculateSumFrom1ToN(n);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(17, true)]
    [InlineData(25, false)]
    [InlineData(29, true)]
    [InlineData(1, false)]
    [InlineData(0, false)]
    [InlineData(-5, false)]
    public void IsPrime_ShouldReturnCorrectResult(int number, bool expected)
    {
        // Act
        var result = SyntaxTasks.IsPrime(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, new[] { 0 })]
    [InlineData(2, new[] { 0, 1 })]
    [InlineData(5, new[] { 0, 1, 1, 2, 3 })]
    [InlineData(7, new[] { 0, 1, 1, 2, 3, 5, 8 })]
    [InlineData(10, new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
    public void GenerateFibonacciArray_ShouldReturnCorrectSequence(int n, int[] expected)
    {
        // Act
        var result = SyntaxTasks.GenerateFibonacciArray(n);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 2.0)]
    [InlineData(new[] { 5, 5, 5, 5 }, 5.0)]
    [InlineData(new[] { 10, 20, 30, 40 }, 25.0)]
    [InlineData(new[] { -1, 0, 1 }, 0.0)]
    [InlineData(new[] { 2 }, 2.0)]
    [InlineData(new int[0], 0.0)]
    public void CalculateArrayAverage_ShouldReturnCorrectAverage(int[] numbers, double expected)
    {
        // Act
        var result = SyntaxTasks.CalculateArrayAverage(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("", true)]
    [InlineData("a", true)]
    [InlineData("radar", true)]
    [InlineData("hello", false)]
    [InlineData("A man a plan a canal Panama", true)]
    [InlineData("Racecar", true)]
    [InlineData("Was it a car or a cat I saw", true)]
    [InlineData("not a palindrome", false)]
    public void IsStringPalindrome_ShouldReturnCorrectResult(string text, bool expected)
    {
        // Act
        var result = SyntaxTasks.IsStringPalindrome(text);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TransposeMatrix_ShouldSwapRowsAndColumns()
    {
        // Arrange
        int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] expected =
        {
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 3, 6, 9 }
        };

        // Act
        var result = _syntaxTasks.TransposeMatrix(matrix);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TransposeMatrix_ShouldHandleRectangularMatrix()
    {
        // Arrange
        int[,] matrix =
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 }
        };

        int[,] expected =
        {
            { 1, 5 },
            { 2, 6 },
            { 3, 7 },
            { 4, 8 }
        };

        // Act
        var result = _syntaxTasks.TransposeMatrix(matrix);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 1, 1, new double[] { -1 })] // x + 1 = 0
    [InlineData(1, -3, 2, new double[] { 1, 2 })] // x² - 3x + 2 = 0
    [InlineData(1, 2, 1, new double[] { -1 })] // x² + 2x + 1 = 0 (один корень)
    [InlineData(1, 0, 1, new double[0])] // x² + 1 = 0 (нет действительных корней)
    [InlineData(0, 2, 4, new double[] { -2 })] // 2x + 4 = 0 (линейное уравнение)
    [InlineData(2, -4, -6, new double[] { -1, 3 })] // 2x² - 4x - 6 = 0
    [InlineData(1, -5, 6, new double[] { 2, 3 })] // x² - 5x + 6 = 0
    public void SolveQuadraticEquation_ShouldReturnCorrectRoots(double a, double b, double c, double[] expected)
    {
        // Act
        var result = SyntaxTasks.SolveQuadraticEquation(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SolveQuadraticEquation_ShouldHandleZeroA()
    {
        // Arrange
        double a = 0, b = 2, c = 4;

        // Act
        var result = SyntaxTasks.SolveQuadraticEquation(a, b, c);

        // Assert
        Assert.Single(result);
        Assert.Equal(-2, result[0]);
    }

    [Fact]
    public void SolveQuadraticEquation_ShouldReturnEmptyArrayForNoRealRoots()
    {
        // Arrange
        double a = 1, b = 0, c = 1; // x² + 1 = 0

        // Act
        var result = SyntaxTasks.SolveQuadraticEquation(a, b, c);

        // Assert
        Assert.Empty(result);
    }
}