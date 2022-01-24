namespace TestCasePracticeLib.Tests;

using Xunit;

public class NameHelperTests
{
    [Theory]
    [InlineData("Marty McFly", "MM")]
    [InlineData("Emmet Brown", "EB")]
    [InlineData("Einstein", "E")]
    public void GetInitials_ValidInput_ShouldReturnInitials(string name, string expected)
    {
        var actual = NameHelper.GetInitials(name);
        Assert.Equal(expected, actual);
    }

    [Theory]
    // ReSharper disable once AssignNullToNotNullAttribute
    [InlineData(null, "")]
    [InlineData("", "")]
    public void GetInitials_InvalidInput_ShouldReturnEmptyString(string input, string expected)
    {
        var actual = NameHelper.GetInitials(input);

        Assert.Equal(expected, actual);
    }

        [Theory]
        [InlineData("Marty McFly", new[] { "Marty", "McFly" })]
        [InlineData("Emmet Brown", new[] { "Emmet", "Brown" })]
        [InlineData("Einstein", new[] { "Einstein" })]
        public void GetNames_ValidInput_ShouldReturnCorrectStringArray(string name, string[] expected)
        {
            var actual = NameHelper.GetNames(name);
            Assert.Equal(expected, actual);
        }
        [Theory]
        // ReSharper disable once AssignNullToNotNullAttribute
        [InlineData(null, new[] { "" })]
        [InlineData("", new[] { "" })]
        public void GetNames_InvalidInput_ShouldReturnEmptyStringArray(string input, string[] expected)
        {
            var actual = NameHelper.GetNames(input);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("marty mcfly", "Marty Mcfly")]
    [InlineData("emmet brown", "Emmet Brown")]
    [InlineData("einstein", "Einstein")]
    [InlineData("BIFF TANNEN","Biff Tannen")]
    public void GetProperName_ValidValue_ShouldReturnNamesWithCapitalFirstLetter(string name, string expected)
    {
        var actual = NameHelper.GetProperName(name);
        Assert.Equal(expected, actual);
    }
    [Theory]
    // ReSharper disable once AssignNullToNotNullAttribute
    [InlineData(null, "")]
    [InlineData("", "")]
    public void GetProperName_InvalidValue_ShouldReturnEmptyString(string name, string expected)
    {
        Assert.Equal(expected, NameHelper.GetProperName(name));
    }
}