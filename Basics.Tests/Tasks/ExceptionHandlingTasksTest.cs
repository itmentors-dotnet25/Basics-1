using Basics.Tasks;
using Xunit;

namespace Basics.Test.Tasks;

public class ExceptionHandlingTasksTests
{
    private readonly ExceptionHandlingTasks _exceptionTasks = new();

    [Fact]
    public void SafeDivide_ShouldReturnResult_WhenDenominatorIsNotZero()
    {
        // Act
        var result = _exceptionTasks.SafeDivide(10, 2);

        // Assert
        Assert.Equal(5, result);
    }

    [Theory]
    [InlineData("123", 123)]
    [InlineData("-456", -456)]
    [InlineData("abc", null)]
    [InlineData("", null)]
    public void ParseStringToInt_ShouldHandleInvalidInput(string input, int? expected)
    {
        // Act
        var result = _exceptionTasks.ParseStringToInt(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ValidatePositiveNumber_ShouldNotThrow_WhenNumberIsPositive()
    {
        // Act & Assert
        var exception = Record.Exception(() => _exceptionTasks.ValidatePositiveNumber(5));

        // Assert
        Assert.Null(exception);
    }
}