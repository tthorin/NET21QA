using Xunit;
using TDDFirst;

namespace TDDFirst.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator calc;
        public CalculatorTests()
        {
            calc = new();
        }

        [Theory]
        [InlineData(5,2,7)]
        [InlineData(2.5555, 2, 4.5555)]
        [InlineData(-5, 5, 0)]
        [InlineData(-5, -5, -10)]
        public void Add_ShouldAddNumbersCorrectly(double x,double y,double expected)
        {   
            var actual = calc.Add(x, y);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(2.5555, 2, 0.5555)]
        [InlineData(-5, 5, -10)]
        [InlineData(-5, -5, 0)]
        public void Subtract_ShouldSubtractNumbersCorrectly(double x, double y, double expected)
        {
            var actual = calc.Subtract(x, y);

            Assert.Equal(expected, actual,6);
        }
        [Theory]
        [InlineData(0, 2, 0)]
        [InlineData(3, 2, 6)]
        [InlineData(2.5, 3, 7.5)]
        [InlineData(2.5555, 0, 0)]
        [InlineData(-5, 5, -25)]
        [InlineData(-5, -5, 25)]
        public void Multiply_ShouldMyltiplyNumbersCorrectly(double x, double y, double expected)
        {
            var actual = calc.Multiply(x, y);

            Assert.Equal(expected, actual, 6);
        }
        [Theory]
        [InlineData(0, 2, 0)]
        [InlineData(3, 2, 1.5)]
        [InlineData(7.5, 3, 2.5)]
        [InlineData(5, 5, 1)]
        [InlineData(-5, -2, 2.5)]
        public void Divide_ShouldDivideNumbersCorrectly(double x, double y, double expected)
        {
            var actual = calc.Divide(x, y);

            Assert.Equal(expected, actual, 6);
        }
        [Fact]
        public void Divide_DivideByZeroShouldReturnZero()
        {
            var expected = 0d;
            var actual = calc.Divide(1, 0);

            Assert.Equal(expected, actual, 6);
        }
    }
}