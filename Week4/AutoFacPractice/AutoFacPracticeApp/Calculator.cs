// -----------------------------------------------------------------------------------------------
//  Calculator.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using AutoFacPracticeApp.Interfaces;

namespace AutoFacPracticeApp;

public class Calculator : ICalculator
{
    private readonly IStringOutput _stringOutput;

    public Calculator(IStringOutput stringOutput) => _stringOutput = stringOutput;

    public int Add(int a, int b) => a + b;

    public int Subtract(int num1, int num2) => num1 - num2;

    public float Divide(float a, float b) => a / b;
}