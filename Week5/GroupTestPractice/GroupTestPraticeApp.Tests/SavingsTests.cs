// -----------------------------------------------------------------------------------------------
//  SavingsTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using GroupTestPracticeApp;
using Xunit;

namespace GroupTestPraticeApp.Tests;

public class SavingsTests
{
    private readonly Savings _sut;

    public SavingsTests()
    {
        _sut = new Savings(1000, 3);
    }
    
    [Fact]
    public void GetAmountAfterOneYear_ShouldWork()
    {
        const int expected = 12360;
        var actual = _sut.GetAmountAfterOneYear();
        Assert.Equal(expected,actual);
    }
    
    [Theory]
    [InlineData(1, 12360)]
    [InlineData(3, 38203.524)]
    [InlineData(5, 65620.9186116)]
    [InlineData(10, 141693.54828977823124188)]
    public void GetSavingsAfterNumberOfYears_ShouldWork(int years,decimal expected)
    {   
        var actual = _sut.GetSavingsAfterNumberOfYears(years);
        Assert.Equal(expected,actual,9);
    }
}