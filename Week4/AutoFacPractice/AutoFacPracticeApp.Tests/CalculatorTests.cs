using System.Collections;
using Autofac.Extras.Moq;
using AutoFacPracticeApp.Interfaces;
using Moq;
using Xunit;

namespace AutoFacPracticeApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ValidNumber_ShouldWork()
    {
        using var mock = AutoMock.GetLoose();
        mock!.Mock<IStringOutput>();

        var calc = mock.Create<Calculator>();
        calc!.Add(8, 4);
        mock.Mock<IStringOutput>()!.Verify(x => x.Output("12"), Times.Exactly(1));
    }

    [Theory]
    [InlineData(new[] {1, 2, 3, 4, 5}, new[] {1, 2, 3, 4, 5})]
    [InlineData(new[] {1, 2, 3, 4, 5}, new[] {1, 2, 3, 4, 4})]
    [InlineData(new[] {"a", "b", "c"}, new[] {"a", "b", "c"})]
    [InlineData(new[] {"a", "b", "c"}, new[] {"a", "b", "d"})]
    public void TestSomething(IList arr1, IList arr2)
    {
        Assert.Equal(arr1, arr2);
    }

    [Fact]
    public void Divide_ShouldWork()
    {
        var calc = new Calculator(new ConsoleStringOutput());
        var expected = 0.91f;

        var actual = calc.Divide(10, 11);
        Assert.Equal(expected,actual,2);
        
    }
}