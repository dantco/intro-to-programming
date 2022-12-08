
namespace StringCalculator;

public class StringCalculatorTests
{
    private readonly StringCalculator _calculator;
    public StringCalculatorTests()
    {
        _calculator = new StringCalculator(new Mock<ILogger>().Object,
            new Mock<IWebService>().Object);
    }
    [Fact]
    public void EmptyStringReturnsZero()
    {
        

        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("108", 108)]
    public void SingleNumber(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,2", 4)]
    public void DoubleNumbers(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
}
