// -----------------------------------------------------------------------------------------------
//  Calc.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace TDDThursday
{
    public static class Calc
    {
        public static double CalcThreeNumbersTwoOperators(double num1, char op1, double num2, char op2, double num3)
        {
            if ((op1 == '/' && num2 == 0) || (op2 == '/' && num3 == 0)) return -1;
            if (!"+-/*".Contains(op1) || !"+-/*".Contains(op2)) return -1;

            double result = 0;
            if ("+-".Contains(op1))
            {
                var secondPart = DoMath(num2, num3, op2);
                result = secondPart == 0 && op1 == '/' ? -1 : DoMath(num1, secondPart, op1);
            }
            else
            {
                var firstPart = DoMath(num1, num2, op1);
                result = DoMath(firstPart, num3, op2);
            }

            return result >= double.MaxValue || result <= double.MinValue ? -1 : result;
        }
        private static double DoMath(double num1, double num2, char op)
        {
            var sum = op switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '/' => num1 / num2,
                _ => num1 * num2
            };
            return sum;
        }
    }
}