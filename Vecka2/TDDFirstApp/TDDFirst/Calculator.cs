// -----------------------------------------------------------------------------------------------
//  Calculator.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace TDDFirst
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Calculator
    {
        public double Add(double x, double y) => x + y;

        public double Subtract(double x, double y) => x-y;

        public double Multiply(double x, double y) => x*y;

        public double Divide(double x, double y) => y == 0 ? 0 : x / y;
    }
}
