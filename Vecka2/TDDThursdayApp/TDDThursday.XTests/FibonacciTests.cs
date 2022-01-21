namespace TDDThursday.XTests
{
    using TDDThursday;
    using Xunit;

    public class FibonacciTests
    {
        
        [Theory]
        [InlineData(1,3)]
        [InlineData(2, 5)]
        [InlineData(3, 8)]
        public void Fibonacci_ShouldReturnExpectedNumber(int input,int expected)
        {
            var actual = Fibonacci.FibonacciSum(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 0)]
        public void Fibonacci_ShouldBeAbleToHandleNegativeNumbers(int input, int expected)
        {
            var actual = Fibonacci.FibonacciSum(input);

            Assert.Equal(expected, actual);
        }
    }
}