using System.IO.Pipes;

namespace CSharpSyntax;

public class UnitTest1
{
    [Fact]
    public void TestingTheAdditionOperatorOnIntegers()
    {
        int a = 10, b = 20, answer;
        answer = a + b;
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(2,2,4)]
    [InlineData(10, 5, 15)]
    [InlineData(13,3,16)]
    public void CanAddAnyTwoIntegers(int a, int b, int c)
    {
        int answer = a + b;
        Assert.Equal(c, answer);
    }
}