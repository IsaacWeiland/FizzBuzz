namespace FizzBuzz.Test;

public class UnitTest1
{
    [Theory]
    [InlineData(3, "fizz")]
    [InlineData(5, "buzz")]
    [InlineData(15, "fizzbuzz")]
    [InlineData(12, "fizz")]
    [InlineData(11, "Not fizzy or buzzy.")]
    public void Test1(int number, string expected)
    {
        var test = new FizzBuzzClass();
        var actual = test.Run(number);
        Assert.Equal(expected, actual);
    }
}