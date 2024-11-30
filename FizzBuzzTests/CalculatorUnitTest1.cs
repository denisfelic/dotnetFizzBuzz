using FizzBuzzTddExample;
using FizzBuzzTddExample.src;

namespace FizzBuzzTests;

public class CalculatorUnitTest1
{
    [Fact]
    public void CalculatorUnitTest()
    {
        var calculator = new Calculator();

        var result = calculator.Sum(1, 2);

        Assert.Equal(3, result);

    }
}