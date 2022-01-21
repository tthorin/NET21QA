// -----------------------------------------------------------------------------------------------
//  XNumberHelperTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Xunit;

namespace TDDThursday.Tests
{
    public class XNumberHelperTests
    {
        #region HighAndLow_Tests

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 3 })]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 3 })]
        [InlineData(new int[] { -3, 2, 1 }, new int[] { -3, 2 })]
        public void HighAndLow_ShouldReturnIntArrayWithHighestAndLowestNumber(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.HighAndLow(numbers);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, new int[] { 1, 1 })]
        [InlineData(new int[] { 3 }, new int[] { 3, 3 })]
        public void HighAndLow_ShouldReturnIntArraySameNumberTwiceOnInputArrayWithOneOrSameNumbers(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.HighAndLow(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HighAndLow_ShouldNotCrashOnNullValues()
        {
            int[] test = null;
            int[] expected = { 0, 0 };

            var actual = NumberHelper.HighAndLow(test);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HighAndLow_ShouldReturnZeroAndZeroOnEmptyArrayInput()
        {
            int[] test = System.Array.Empty<int>();
            int[] expected = { 0, 0 };

            var actual = NumberHelper.HighAndLow(test);

            Assert.Equal(expected, actual);
        }

        #endregion HighAndLow_Tests

        #region MoveTheZeroes_Test

        [Theory]
        [InlineData(new int[] { 1, 0, 2, 0, 3, 0 }, new int[] { 1, 2, 3, 0, 0, 0 })]
        [InlineData(new int[] { 0, 1 }, new int[] { 1, 0 })]
        public void MoveTheZeroes_ShouldMoveZeroesToEnd(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.MoveTheZeroes(numbers);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { }, new int[] { 0 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        public void MoveTheZeroes_ShouldBeAbleToHandleEmptyOrSingleValueArray(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.MoveTheZeroes(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MoveTheZeroes_ShouldBeAbleToHandleNullInput()
        {
            int[] test = null;
            int[] expected = { 0 };
            var actual = NumberHelper.MoveTheZeroes(test);

            Assert.Equal(expected, actual);
        }

        #endregion MoveTheZeroes_Test

        #region OddNumber_Tests

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 3, 5 },1)]
        [InlineData(new int[] { 2, 2, 2, 4, 5, 2, 4, 4, 5 }, 4)]
        [InlineData(new int[] { 2, 0, 0, 0, 0, 0, 0, 0, 2 }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        public void OddNumber_ShouldReturnCorrectNumber(int[] numbers,int expected)
        {
            var actual = NumberHelper.OddNumber(numbers);

            Assert.Equal(expected,actual);
        }
        [Fact]
        public void OddNumber_ShouldReturnNegativeOneOnNullInput()
        {
            int[] test = null;
            var expected = -1;

            var actual = NumberHelper.OddNumber(test);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void OddNumber_ShouldReturnNegativeOneOnEmptyInput()
        {
            int[] test = System.Array.Empty<int>();
            var expected = -1;

            var actual = NumberHelper.OddNumber(test);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void OddNumber_ShouldReturnNegativeOneOnNoOddOccurance()
        {
            int[] test = { 1, 1 };
            var expected = -1;

            var actual = NumberHelper.OddNumber(test);

            Assert.Equal(expected, actual);
        }

        #endregion Oddnumber_Tests
    }
}