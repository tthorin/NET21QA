namespace StringHelper.Tests
{
    using System.Collections.Generic;
    using Xunit;
    using static System.Net.Mime.MediaTypeNames;
    using static TddPractice1.StringHelper;

    public class StringHelperTests
    {
        #region GetWord_Tests
        [Theory]
        [InlineData("Hello World", 1, ' ', "World")]
        [InlineData("Thomas,Thorin", 0, ',', "Thomas")]
        [InlineData("HejHopp", 0, ' ', "HejHopp")]
        [InlineData("Hola Hej Hopp", 3, ' ', "Hopp")]

        public void GetWord_ShouldReturnCorrectWordForGivenIndex(string text, int idx, char separator, string expected)
        {
            var actual = GetWord(text, idx, separator);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetWord_TooLowIndexShouldReturnEmptyString()
        {
            const string? text = "Hej Hopp";
            const int idx = -1;
            const string? expected = "";
            var actual = GetWord(text, idx);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetWord_TooHighIndexShouldReturnLastWord()
        {
            const string? text = "Hej Hopp";
            const int idx = 150;
            const string expected = "Hopp";
            var actual = GetWord(text, idx);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetWord_NullStringInputShouldReturnEmptyString()
        {
            const string? data = null;
            const string expected = "";

            var actual = GetWord(data, 0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetWord_ShouldBeAbleToDealWithFollowingSeparators()
        {
            const string data = "Hej,,Hopp";
            const string expected = "Hopp";

            var actual = GetWord(data, 1, ',');
            Assert.Equal(expected, actual);
        }
        #endregion GetWord_Tests

        #region StringToList_Tests
        [Fact]
        public void StringToList_ListShouldBeExpectedLength()
        {
            var data = "The quick brown fox jumps over the lazy dog";
            var expectedCount = 9;
            var actual = StringToList(data);

            Assert.Equal(expectedCount, actual.Count);
        }
        [Fact]
        public void StringToList_ShouldReturnEmptyListOnNullStringInput()
        {
            string data = null;

            var actual = StringToList(data);

            Assert.Empty(actual);
        }

        [Fact]
        public void StringToList_ShouldReturnListCountOneWhenTextIsMissingSeparator()
        {
            var text = "Hej hopp";
            var sep = ',';
            var expected = 1;

            var actual = StringToList(text, sep);

            Assert.Equal(expected, actual.Count);
        }
        #endregion StringToList_Tests

        #region RemoveWord_Tests
        [Fact]
        public void RemoveWord_ShouldRemoveGivenWord()
        {
            string text = "Quick brown fox";
            var remove = "brown";

            var expected = "Quick fox";

            var actual = RemoveWord(text, remove);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RemoveWord_ShouldReturnEmptyStringOnNullOrEmptyText()
        {
            string text = null;
            string remove = "whatever";
            var expected = "";

            var actual = RemoveWord(text, remove);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RemoveWord_ShouldReturnEmptyStringOnNullOrEmptyRemove()
        {
            string text = "whatever";
            string remove = null;
            var expected = "";

            var actual = RemoveWord(text, remove);

            Assert.Equal(expected, actual);
        }
        #endregion RemoveWord_Tests

        #region RemoveWordAt_Tests
        [Fact]
        public void RemoveWordAt_ShouldRemoveCorrectWord()
        {
            var text = "A cat in a hat";
            var pos = 2;
            var expected = "A cat a hat";

            var actual = RemoveWordAt(text, pos);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A cat in a hat", -1, "A cat in a hat")]
        [InlineData("A cat in a hat", 25, "A cat in a hat")]
        public void RemoveWordAt_ShouldReturnFullTextWhenPosIsOutOfRange(string text, int pos, string expected)
        {
            var actual = RemoveWordAt(text, pos);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RemoveWordAt_ShouldReturnEmptyStringOnNullOrEmptyText()
        {
            var text = "";
            var pos = 0;

            var expected = string.Empty;
            var actual = RemoveWordAt(text, pos);

            Assert.Equal(expected, actual);
        }
        #endregion RemoveWordAt_Tests

        #region InsertWordAfter_Tests
        [Theory]
        [InlineData("A cat in a hat", "a", "huge", "A cat in a huge hat")]
        [InlineData("Trust the force", "force", "cat", "Trust the force cat")]
        public void InsertWordAfter_AddingWordShouldWork(string text, string after, string add, string expected)
        {
            var actual = InsertWordAfter(text, after, add);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InsertWordAfter_ShouldReturnUnmodifiedTextOnNullOrEmptyAfterOrAdd()
        {
            var expected = "Trust the force";
            var actual = InsertWordAfter("Trust the force", "", "meow");
            Assert.Equal(expected, actual);
        }
        #endregion InsertWordAfter_Tests

        #region SwapWords_Tests
        [Fact]
        public void SwapWords_ShouldSwapWords()
        {
            var text = "It's not wise to upset a Wookiee.";
            var word1 = 1;
            var word2 = 3;
            var expected = "It's to wise not upset a Wookiee.";

            var actual = SwapWords(text, word1, word2);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("It's not wise to upset a Wookiee.", -1, 4, "It's not wise to upset a Wookiee.")]
        [InlineData("It's not wise to upset a Wookiee.", 1, 124, "It's not wise to upset a Wookiee.")]
        public void SwapWords_OutOfRangeSwapWordIndexShouldReturnUnmodifiedText(string text, int word1, int word2, string expected)
        {
            var actual = SwapWords(text, word1, word2);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SwapWords_ShouldReturnUnmodifiedTextWhenSwappingSameWord()
        {
            var text = "It's not wise to upset a Wookiee.";
            var word1 = 1;
            var word2 = 1;
            var expected = "It's not wise to upset a Wookiee.";

            var actual = SwapWords(text, word1, word2);

            Assert.Equal(expected, actual);
        }
        #endregion SwapWords_Tests
    }
}