using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDThursday;

namespace TDDThursday.Tests
{
    [TestClass]
    public class NumberHelperTests
    {
        #region HighAndLow_Tests
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 3 })]
        [DataRow(new int[] { 3, 2, 1 }, new int[] { 1, 3 })]
        [DataRow(new int[] { -3, 2, 1 }, new int[] { -3, 2 })]
        public void HighAndLow_ShouldReturnIntArrayWithHighestAndLowestNumber(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.HighAndLow(numbers);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(new int[] { 1, 1, 1 }, new int[] {1,1})]
        [DataRow(new int[] { 3 }, new int[] { 3,3 })]
        public void HighAndLow_ShouldReturnIntArraySameNumberTwiceOnInputArrayWithOneOrSameNumbers(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.HighAndLow(numbers);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HighAndLow_ShouldNotCrashOnNullValues()
        {
            int[] test = null;
            int[] expected = { 0, 0 };

            var actual = NumberHelper.HighAndLow(test);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HighAndLow_ShouldReturnZeroAndZeroOnEmptyArrayInput()
        {
            int[] test = System.Array.Empty<int>();
            int[] expected = { 0, 0 };

            var actual = NumberHelper.HighAndLow(test);

            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion HighAndLow_Tests

        #region MoveTheZeroes_Test
        [TestMethod]
        [DataRow(new int[] { 1, 0, 2, 0, 3, 0,0 }, new int[] { 1, 2, 3, 0, 0, 0 })]
        [DataRow(new int[] { 0,1 }, new int[] {  1,0 })]
        public void MoveTheZeroes_ShouldMoveZeroesToEnd(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.MoveTheZeroes(numbers);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 1 }, new int[] { 1 })]
        public void MoveTheZeroes_ShouldBeAbleToHandleEmptyOrSingleValueArray(int[] numbers, int[] expected)
        {
            var actual = NumberHelper.MoveTheZeroes(numbers);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
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