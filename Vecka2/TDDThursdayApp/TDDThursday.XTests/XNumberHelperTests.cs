// -----------------------------------------------------------------------------------------------
//  XNumberHelperTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            CollectionAssert.AreEqual(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, new int[] { 1, 1 })]
        [InlineData(new int[] { 3 }, new int[] { 3, 3 })]
        public void HighAndLow_ShouldReturnIntArraySameNumberTwiceOnInputArrayWithOneOrSameNumbers(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.HighAndLow(numbers);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Fact]
        public void HighAndLow_ShouldNotCrashOnNullValues()
        {
            int[] test = null;
            int[] expected = { 0, 0 };

            var actual = NumberHelper.HighAndLow(test);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Fact]
        public void HighAndLow_ShouldReturnZeroAndZeroOnEmptyArrayInput()
        {
            int[] test = System.Array.Empty<int>();
            int[] expected = { 0, 0 };

            var actual = NumberHelper.HighAndLow(test);

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion HighAndLow_Tests

        #region MoveTheZeroes_Test

        [Theory]
        [InlineData(new int[] { 1, 0, 2, 0, 3, 0 }, new int[] { 1, 2, 3, 0, 0, 0 })]
        [InlineData(new int[] { 0, 1 }, new int[] { 1, 0 })]
        public void MoveTheZeroes_ShouldMoveZeroesToEnd(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.MoveTheZeroes(numbers);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { }, new int[] { 0 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        public void MoveTheZeroes_ShouldBeAbleToHandleEmptyOrSingleValueArray(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.MoveTheZeroes(numbers);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Fact]
        public void MoveTheZeroes_ShouldBeAbleToHandleNullInput()
        {
            int[] test = null;
            int[] expected = { 0 };
            var actual = NumberHelper.MoveTheZeroes(test);

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion MoveTheZeroes_Test
    }
}