// -----------------------------------------------------------------------------------------------
//  SalaryTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;
using Xunit;

namespace GroupTestPracticeApp.Tests;

public class SalaryTests
{
    private readonly Salary _sut;

    public SalaryTests()
    {
        _sut = new Salary(33000);
    }

    [Fact]
    public void GetHourlySalary_ShouldWork()
    {
        const decimal expected = 206.25M;
        var actual = _sut.GetHourlySalary();
        Assert.Equal(expected,actual);
    }

    [Theory]
    [InlineData(0, 5, 8)]
    [InlineData(6, 5, 8)]
    [InlineData(4, 8, 8)]
    [InlineData(4, 0, 8)]
    [InlineData(4, 5, 0)]
    [InlineData(4, 5, 25)]
    public void GetHourlySalary_InvalidInput_ShouldThrowException(int weeks, int days, int hours)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _sut.GetHourlySalary(weeks, days, hours));
    }
    
    [Fact]
    public void GetYearlySalary_ShouldWork()
    {
        const decimal expected = 396000M;
        var actual = _sut.GetYearlySalary();
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void GetYearlySocialFee_ShouldWork()
    {
        var expected = 124423.2M;
        var actual = _sut.GetYearlySocialFee();
        Assert.Equal(expected,actual);
    }
}