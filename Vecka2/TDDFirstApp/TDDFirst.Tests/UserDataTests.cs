using Xunit;
using TDDFirst;

namespace TDDFirst.Tests
{
    public class UserDataTests
    {
        #region Setup
        private readonly UserData ud;
        public UserDataTests()
        {
            ud = new();
        }
        #endregion Setup

        #region IsPasswordOk_Tests
        [Theory]
        [InlineData("Abcde.", false)]
        [InlineData("Abcdef.", true)]
        public void IsPasswordOK_PasswordShouldBeLongerThenSixChars(string password, bool expected)
        {
            var actual = ud.IsPasswordOK(password);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(24, false)]
        [InlineData(23, true)]
        public void IsPasswordOK_PasswordMaxLenghtShouldBe25Chars(int stringLength, bool expected)
        {
            var password = ".A"+new string('a', stringLength);
            var actual = ud.IsPasswordOK(password);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("ABCDEF.", false)]
        [InlineData("aBCDEF.", true)]
        public void IsPasswordOK_PasswordShouldHaveAtLeastOneLowerCase(string password, bool expected)
        {
            var actual = ud.IsPasswordOK(password);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Abcdefg", false)]
        [InlineData("Abcdef!", true)]
        [InlineData("Abcdef.", true)]
        [InlineData("Abcdef:", true)]
        [InlineData("Abcdef$", true)]
        [InlineData("Abcdef%", true)]
        [InlineData("Abcdef&", true)]
        [InlineData("Abcdef(", true)]
        [InlineData("Abcdef)", true)]
        [InlineData("Abcdef=", true)]
        [InlineData("Abcdef/", true)]
        public void IsPasswordOK_PasswordShouldHaveAtLeastOneSpecialCharacter(string password, bool expected)
        {
            var actual = ud.IsPasswordOK(password);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsPasswordOk_ShouldReturnFalseOnNullStringInput()
        {
            string password = null;
            Assert.False(ud.IsPasswordOK(password));
        }
        #endregion IsPasswordOk_Tests

        #region IsEmailOk_Tests
        [Theory]
        [InlineData("tom.tom@something.com",true)]
        [InlineData("tom@something.com", true)]
        [InlineData("@something.com", false)]
        [InlineData("tom..tom@something.com", false)]
        [InlineData("tom.@something.com", false)]
        [InlineData(".tom@something.com", false)]
        public void IsEmailOk_ShouldAllowOneOrTwoNames(string email,bool expected)
        {
            var actual = ud.IsEmailOk(email);
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData("tom.tom@something.com", true)]
        [InlineData("tom.tomsomething.com", false)]
        [InlineData("tom.tom@some@thing.com", false)]
        public void IsEmailOk_ShouldMakeSureEmailContainsASingleAtSign(string email, bool expected)
        {
            var actual = ud.IsEmailOk(email);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("tom.tom@something.com", true)]
        [InlineData("Tom.Tom@something.com", false)]
        public void IsEmailOk_ShouldOnlyAllowLowerCaseLetters(string email, bool expected)
        {
            var actual = ud.IsEmailOk(email);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("to+m.tom@something.com", false)]
        [InlineData("Tom.Tom@so!mething.com", false)]
        public void IsEmailOk_ShouldCheckForInvalidCharacters(string email, bool expected)
        {
            var actual = ud.IsEmailOk(email);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(54, true)]
        [InlineData(55, false)]
        public void IsEmailOk_ShouldCheckForMaxLength60(int stringLength, bool expected)
        {
            var email = "a@" + new string('a', stringLength) + ".com"; //a@ + .com is lenght 6
            var actual = ud.IsEmailOk(email);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, true)]
        [InlineData(51, false)]
        public void IsEmailOk_ShouldCheckNamePartMaxLength50(int stringLength, bool expected)
        {
            var email = new string('a', stringLength) + "@a.aa"; //@a.aa lenght is 5
            var actual = ud.IsEmailOk(email);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("tom tom@something.com", false)]
        [InlineData("tom.tom@som ething.com", false)]
        public void IsEmailOk_ShouldFailOnEmailsContainingSpace(string email, bool expected)
        {
            var actual = ud.IsEmailOk(email);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void IsEmailOk_ShouldReturnFalseOnNullInput()
        {
            string email = null;
            var actual = ud.IsEmailOk(email);
            Assert.False(actual);
        }
        #endregion IsEmailOk_Tests

        #region IsPhoneOk_Tests
        [Theory]
        [InlineData("0708666666",false)]
        [InlineData("+0708666666", true)]
        public void IsPhoneOk_ShouldStartWithPlus(string phoneNumber,bool expected)
        {
            var actual = ud.IsPhoneOk(phoneNumber);

            Assert.Equal(expected,actual);
        }
        [Theory]
        [InlineData("+0708a66666", false)]
        [InlineData("+46 0708 66 66 66", false)]
        [InlineData("+46708666666", true)]
        public void IsPhoneOk_ShouldOnlyContainDigits(string phoneNumber, bool expected)
        {
            var actual = ud.IsPhoneOk(phoneNumber);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("+", false)]
        [InlineData("+4", true)]
        public void IsPhoneOk_ShouldBeAtleastOneDigitLong(string phoneNumber, bool expected)
        {
            var actual = ud.IsPhoneOk(phoneNumber);

            Assert.Equal(expected, actual);
        }
        #endregion IsPhoneOk_Tests
    }
}
// -----------------------------------------------------------------------------------------------
//  UserDataTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------
