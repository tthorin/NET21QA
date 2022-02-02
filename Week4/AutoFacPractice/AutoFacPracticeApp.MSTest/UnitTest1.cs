using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoFacPracticeApp.MSTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow(1,1,2), Description("1+1=2")]
    public void TestMethod1(int num1, int num2,int expected)
    {
        var calc = new Calculator(new ConsoleStringOutput());
        Assert.IsInstanceOfType(calc,typeof(Calculator));
        Assert.AreEqual(expected,calc.Add(num1,num2));
    }
}