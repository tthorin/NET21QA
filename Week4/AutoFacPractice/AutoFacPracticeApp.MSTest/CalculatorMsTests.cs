using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoFacPracticeApp.MSTest;

[TestClass]
public class UnitTest1
{
    private Calculator _calc;
    [TestInitialize]
    public void Setup()
    {
        _calc = new Calculator(new ConsoleStringOutput());
    }
    
    [TestMethod]
    [DataRow(1,1,2), Description("1+1=2")]
    public void TestMethod1(int num1, int num2,int expected)
    {
        
        Assert.IsInstanceOfType(_calc,typeof(Calculator));
        Assert.AreEqual(expected,_calc.Add(num1,num2));
    }
    [TestMethod]
    [DataRow(2,1,1), Description("1+1=2")]
    public void TestMethod2(int num1, int num2,int expected)
    {
        Assert.AreEqual(expected,_calc.Subtract(num1,num2));
    }

    [TestMethod]
    public void Divide_ShouldWork()
    {
        var expected = 0.91f;
        var actual = _calc.Divide(10, 11);
        Assert.AreEqual(expected,actual,0.001);
    }
}