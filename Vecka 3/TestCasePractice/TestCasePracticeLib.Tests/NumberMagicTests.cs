// -----------------------------------------------------------------------------------------------
//  MagicNumberTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Xunit;

namespace TestCasePracticeLib.Tests;

public class NumberMagicTests
{
    [Fact]
    public void MagicSum_ValidValue_ShouldReturnCorrectResult()
    {
        const int expected = 14;
        var actual = NumberMagic.MagicSum(1337);
        
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void NumWords_ValidValue_ShouldReturnCorrectResult()
    {
        const string expected = "Ett Tre Tre Sju";
        var actual = NumberMagic.NumWords(1337);
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void Roman_ValidValue_ShouldReturnCorrectResult()
    {
        const string expected = "MCCCXXXVII";
        var actual = NumberMagic.Roman(1337);
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void ValueWords_ShouldWork()
    {
        const string expected = "ett tusen tre hundra trettio sju";
        var actual = NumberMagic.NumbersToWords(1337);
        Assert.Equal(expected,actual);
    }
}