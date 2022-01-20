namespace TestCasePracticeLib.Tests
{
    using System;
    using Xunit;

    public class NameHelperTests
    {
        readonly NameHelper nh;
        public NameHelperTests()
        {
            nh = new NameHelper();
        }

        [Theory]
        [InlineData("Marty McFly", "MM")]
        [InlineData("Emmet Brown", "EB")]
        [InlineData("Einstein", "E")]
        public void GetInitials_ValidInput_ShouldReturnInitials(string name, string expected)
        {
            var actual = nh.GetInitials(name);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        public void GetInitials_InvalidInput_ShouldReturnEmptyString(string input, string expected)
        {
            var actual = nh.GetInitials(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Marty McFly", new string[] { "Marty", "McFly" })]
        [InlineData("Emmet Brown", new string[] { "Emmet", "Brown" })]
        [InlineData("Einstein", new string[] { "Einstein" })]
        public void GetNames_ValidInput_ShouldReturnCorrectStringArray(string name, string[] expected)
        {
            var actual = nh.GetNames(name);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(null, new string[] { "" })]
        [InlineData("", new string[] { "" })]
        public void GetNames_InvalidInput_ShouldReturnEmptyStringArray(string input, string[] expected)
        {
            var actual = nh.GetNames(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("marty mcfly", "Marty Mcfly")]
        [InlineData("emmet brown", "Emmet Brown")]
        [InlineData("einstein", "Einstein")]
        [InlineData("BIFF TANNEN","Biff Tannen")]
        public void GetProperName_ValidValue_ShouldReturnNamesWithCapitalFirstLetter(string name, string expected)
        {
            var actual = nh.GetProperName(name);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        public void GetProperName_InvalidValue_ShouldReturnEmptyString(string name, string expected)
        {
            var actual = nh.GetProperName(name);

            Assert.Equal(expected, actual);
        }
    }
}