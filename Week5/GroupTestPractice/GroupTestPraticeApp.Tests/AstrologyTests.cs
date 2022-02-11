// -----------------------------------------------------------------------------------------------
//  AstrologyTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;
using GroupTestPracticeApp;
using Xunit;

namespace GroupTestPraticeApp.Tests;

public class AstrologyTests
{
    private Astrology _sut;

    public AstrologyTests()
    {
        _sut = new();
    }

    [Theory]
    [InlineData(1975,9,21,"Jungfru")]
    [InlineData(1986,3,28,"Vädur")]
    public void Sign_ValidDate_ShouldReturnCorrectSign(int year, int month,int day,string expected)
    {
        
        var actual = _sut.Sign(new DateOnly(year, month, day));
        Assert.Equal(expected,actual);
    }

    [Theory]
    [InlineData(2022,3,"Tiger")]
    [InlineData(2021,3,"Buffel")]
    [InlineData(2020,3,"Råtta")]
    [InlineData(2019,3,"Gris")]
    [InlineData(2020,1,"Gris")]
    public void ChineseYear_ShouldWork(int year,int month,string expected)
    {
        var actual = _sut.ChineseYear(new DateOnly(year, month, 1));
        Assert.Equal(expected,actual);
    }
}
