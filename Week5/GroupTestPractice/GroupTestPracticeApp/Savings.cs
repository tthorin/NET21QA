// -----------------------------------------------------------------------------------------------
//  Savings.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace GroupTestPracticeApp;

public class Savings
{
    public decimal MonthlySaving { get; set; }
    public decimal YearlyInterestPercent { get; set; }

    public Savings(decimal monthlySaving = 0M, decimal yearlyInterestPercent = 0M)
    {
        MonthlySaving = monthlySaving;
        YearlyInterestPercent = yearlyInterestPercent;
    }

    public decimal GetAmountAfterOneYear()
    {
        var savings = MonthlySaving * 12;
        return savings + savings * YearlyInterestPercent / 100; 
    }

    public decimal GetSavingsAfterNumberOfYears(int years)
    {
        var savings = 0M;
        for (var i = 0; i < years; i++)
        {
            savings = (savings + MonthlySaving * 12) * (1 + YearlyInterestPercent / 100);
        }

        return savings;
    }
}