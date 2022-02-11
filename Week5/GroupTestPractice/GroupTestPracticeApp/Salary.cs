// -----------------------------------------------------------------------------------------------
//  Salary.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace GroupTestPracticeApp;

public class Salary
{
    public decimal MonthlySalary { get; set; }

    public Salary(decimal salary = 0)
    {
        MonthlySalary = salary;
    }

    public decimal GetHourlySalary(int weeks = 4, int workDaysPerWeek = 5, int workHoursPerDay = 8)
    {
        if(weeks is > 5 or < 1) throw new ArgumentOutOfRangeException("weeks", weeks, "Invalid value for weeks, should be between 1 and 5.");
        if(workDaysPerWeek is > 7 or < 1)throw new ArgumentOutOfRangeException("workDaysPerWeek", workDaysPerWeek, "Invalid value for workdays, should be between 1 and 7.");
        if(workHoursPerDay is > 24 or < 1)throw new ArgumentOutOfRangeException("workHoursPerDay", workHoursPerDay, "Invalid value for workdays, should be between 1 and 24.");
        return MonthlySalary / weeks / workDaysPerWeek / workHoursPerDay;
    }

    public decimal GetYearlySalary() => MonthlySalary * 12;

    public decimal GetYearlySocialFee()
    {
        const decimal socialFeePercent = 31.42M;
        return GetYearlySalary() * socialFeePercent / 100;
    }
}