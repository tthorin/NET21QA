// -----------------------------------------------------------------------------------------------
//  StringHelperTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace TDDThursday.XTests
{
    using System.Collections.Generic;
    using Xunit;

    public class StringHelperTests
    {
        [Fact]
        public void FindVowels_ShouldReturnCorrectDictionary()
{
            var text = "The quick brown fox jumps over the lazy dog, är det tö i Åre?";
            var expected = new Dictionary<char, int> {
                { 'a', 1 },
                { 'e', 5 },
                { 'i', 2 },
                { 'o', 4 },
                { 'u', 2 },
                { 'y', 1 },
                { 'å', 1 },
                { 'ä', 1 },
                { 'ö', 1 }
            };
            var actual = StringHelper.FindVowels(text);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FindVowels_ShouldReturnZeroValuesDictionaryOnNullInput()
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string text = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            var expected = new Dictionary<char, int> {
                { 'a', 0 },
                { 'e', 0 },
                { 'i', 0 },
                { 'o', 0 },
                { 'u', 0 },
                { 'y', 0 },
                { 'å', 0 },
                { 'ä', 0 },
                { 'ö', 0 }
            };
#pragma warning disable CS8604 // Possible null reference argument.
            var actual = StringHelper.FindVowels(text);
#pragma warning restore CS8604 // Possible null reference argument.

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FindVowels_ShouldReturnZeroValuesDictionaryOnEmptyStringInput()
        {
            string text = "";
            var expected = new Dictionary<char, int> {
                { 'a', 0 },
                { 'e', 0 },
                { 'i', 0 },
                { 'o', 0 },
                { 'u', 0 },
                { 'y', 0 },
                { 'å', 0 },
                { 'ä', 0 },
                { 'ö', 0 }
            };
            var actual = StringHelper.FindVowels(text);

            Assert.Equal(expected, actual);
        }
    }
}