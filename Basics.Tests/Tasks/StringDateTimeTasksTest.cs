using Basics.Tasks;

namespace Basics.Test.Tasks;
using Xunit;


public class StringDateTimeTasksTests
{
    private readonly StringDateTimeTasks _stringDateTimeTasks = new();

    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("a", "a")]
    [InlineData("", "")]
    public void ReverseString_ShouldReturnReversedString(string input, string expected)
    {
        // Act
        var result = StringDateTimeTasks.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("radar", true)]
    [InlineData("hello", false)]
    [InlineData("A man a plan a canal Panama", true)]
    public void IsPalindrome_ShouldReturnCorrectResult(string input, bool expected)
    {
        // Act
        var result = StringDateTimeTasks.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ConcatenateStrings_ShouldJoinStrings()
    {
        // Arrange
        var strings = new[] { "Hello", "World", "Test" };

        // Act
        var result = StringDateTimeTasks.ConcatenateStrings(strings);

        // Assert
        Assert.Equal("HelloWorldTest", result);
    }

    [Fact]
    public void CalculateAge_ShouldReturnCorrectAge()
    {
        // Arrange
        var birthDate = DateTime.Now.AddYears(-25).AddDays(-5);

        // Act
        var result = StringDateTimeTasks.CalculateAge(birthDate);

        // Assert
        Assert.Equal(25, result);
    }

    [Fact]
    public void GetDaysDifference_ShouldReturnCorrectDifference()
    {
        // Arrange
        var first = new DateTime(2023, 1, 1);
        var second = new DateTime(2023, 1, 10);

        // Act
        var result = StringDateTimeTasks.GetDaysDifference(first, second);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void FormatDate_ShouldReturnFormattedString()
    {
        // Arrange
        var date = new DateTime(2023, 12, 25);

        // Act
        var result = StringDateTimeTasks.FormatDate(date);

        // Assert
        Assert.Equal("25.12.2023", result);
    }
    
    
    [Theory]
    [InlineData("hello world", new[] { "hello", "world" })]
    [InlineData("one two three", new[] { "one", "two", "three" })]
    [InlineData("single", new[] { "single" })]
    [InlineData("", new string[0])]
    [InlineData("  multiple   spaces  ", new[] { "multiple", "spaces" })]
    public void SplitIntoWords_ShouldSplitStringCorrectly(string text, string[] expected)
    {
        // Act
        var result = StringDateTimeTasks.SplitIntoWords(text);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("hello world", "hello", true)]
    [InlineData("hello world", "world", false)]
    [InlineData("test string", "test", true)]
    [InlineData("test string", "string", false)]
    [InlineData("", "", true)]
    [InlineData("hello", "hello", true)]
    [InlineData("hello", "hell", true)]
    [InlineData("hello", "ello", false)]
    public void StartsWithSubstring_ShouldReturnCorrectResult(string text, string substring, bool expected)
    {
        // Act
        var result = StringDateTimeTasks.StartsWithSubstring(text, substring);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("hello world", "helloworld")]
    [InlineData("  test  string  ", "teststring")]
    [InlineData("no-spaces", "no-spaces")]
    [InlineData("", "")]
    [InlineData("   ", "")]
    [InlineData("a b c d e", "abcde")]
    public void RemoveSpaces_ShouldRemoveAllSpaces(string text, string expected)
    {
        // Act
        var result = StringDateTimeTasks.RemoveSpaces(text);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("hello", 3, "hellohellohello")]
    [InlineData("test", 1, "test")]
    [InlineData("a", 5, "aaaaa")]
    [InlineData("", 10, "")]
    [InlineData("word", 0, "")]
    [InlineData("ab", 4, "abababab")]
    public void RepeatString_ShouldRepeatStringCorrectly(string text, int count, string expected)
    {
        // Act
        var result = StringDateTimeTasks.RepeatString(text, count);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetTimeDifference_ShouldReturnCorrectHoursAndMinutes()
    {
        // Arrange
        var first = new DateTime(2023, 1, 1, 10, 30, 0);
        var second = new DateTime(2023, 1, 1, 14, 45, 0);

        // Act
        var result = StringDateTimeTasks.GetTimeDifference(first, second);

        // Assert
        Assert.Equal(4, result.hours);
        Assert.Equal(15, result.minutes);
    }

    [Fact]
    public void GetTimeDifference_ShouldHandleNegativeDifference()
    {
        // Arrange
        var first = new DateTime(2023, 1, 1, 14, 45, 0);
        var second = new DateTime(2023, 1, 1, 10, 30, 0);

        // Act
        var result = StringDateTimeTasks.GetTimeDifference(first, second);

        // Assert
        Assert.Equal(4, result.hours);
        Assert.Equal(15, result.minutes);
    }

    [Fact]
    public void GetTimeDifference_ShouldHandleSameTime()
    {
        // Arrange
        var first = new DateTime(2023, 1, 1, 10, 30, 0);
        var second = new DateTime(2023, 1, 1, 10, 30, 0);

        // Act
        var result = StringDateTimeTasks.GetTimeDifference(first, second);

        // Assert
        Assert.Equal(0, result.hours);
        Assert.Equal(0, result.minutes);
    }

    [Fact]
    public void GetTimeDifference_ShouldHandleCrossMidnight()
    {
        // Arrange
        var first = new DateTime(2023, 1, 1, 23, 0, 0);
        var second = new DateTime(2023, 1, 2, 1, 30, 0);

        // Act
        var result = StringDateTimeTasks.GetTimeDifference(first, second);

        // Assert
        Assert.Equal(2, result.hours);
        Assert.Equal(30, result.minutes);
    }

    [Theory]
    [InlineData("hello", "HELLO")]
    [InlineData("Test String", "TEST STRING")]
    [InlineData("UPPERCASE", "UPPERCASE")]
    [InlineData("lowercase", "LOWERCASE")]
    [InlineData("", "")]
    [InlineData("123 abc", "123 ABC")]
    [InlineData("Hello World!", "HELLO WORLD!")]
    public void ConvertToUpper_ShouldConvertToUpperCase(string text, string expected)
    {
        // Act
        var result = StringDateTimeTasks.ConvertToUpper(text);

        // Assert
        Assert.Equal(expected, result);
    }
}