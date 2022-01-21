// -----------------------------------------------------------------------------------------------
//  CalcTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace TDDThursday.XTests
{
    using Xunit;

    public class CalcTests
    {
        [Theory]
        [InlineData(1,'+',1,'-',1,1)]
        [InlineData(2, '+', 2, '/', 2, 3)]
        [InlineData(20, '/', 10, '/', 2, 1)]
        public void Calc_ShouldCalculateCorrectly(double num1,char op1,double num2,char op2,double num3,double expected)
        {
            var actual = Calc.CalcThreeNumbersTwoOperators(num1, op1, num2, op2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(double.MaxValue, '*', double.MaxValue, '+', 1, -1)]
        [InlineData(double.MaxValue, '+', 5, '+', 1, -1)]
        [InlineData(double.MinValue, '+', 5, '+', 1, -1)]
        public void Calc_ShouldReturnNegativeOneOnTooBigOrSmallResult(double num1, char op1, double num2, char op2, double num3, double expected)
        {
            var actual = Calc.CalcThreeNumbersTwoOperators(num1, op1, num2, op2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,'a',1,'+',1,-1)]
        [InlineData(1, '+', 1, '&', 1, -1)]
        public void Calc_InvalidOperatorShouldReturnNegativeOne(double num1, char op1, double num2, char op2, double num3, double expected)
        {
            var actual = Calc.CalcThreeNumbersTwoOperators(num1, op1, num2, op2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, '+', 1, '/', 0, -1)]
        [InlineData(1, '/', 0, '+', 1, -1)]
        public void Calc_DivideByZeroShouldReturnNegativeOne(double num1, char op1, double num2, char op2, double num3, double expected)
        {
            var actual = Calc.CalcThreeNumbersTwoOperators(num1, op1, num2, op2, num3);
            Assert.Equal(expected, actual);
        }
    }
}