using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Autofac.Extras.Moq;
using Xunit;
using AutoFacPracticeApp.Interfaces;
using Moq;

namespace AutoFacPracticeApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ValidNumber_ShouldWork()
    {
        using var mock = AutoMock.GetLoose();
        mock.Mock<IStringOutput>();

        var calc = mock.Create<Calculator>();
        calc.Add(8,4);
        mock.Mock<IStringOutput>().Verify(x=>x.Output("12"),Times.Exactly(1));
    }

    [Theory]
    [InlineData(new int[]{1,2,3,4,5},new int[]{1,2,3,4,5})]
    [InlineData(new int[]{1,2,3,4,5},new int[]{1,2,3,4,4})]
    [InlineData(new string[]{"a","b","c"},new string[]{"a","b","c"})]
    [InlineData(new string[]{"a","b","c"},new string[]{"a","b","d"})]
    public void TestSomething(IList<string> arr1,IList arr2)
    {
        
        
        Assert.Equal(arr1,arr2);
    }
}