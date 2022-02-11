// -----------------------------------------------------------------------------------------------
//  CatTest_MsTest.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using AutoFacPracticeApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoFacPracticeApp.MSTest;

[TestClass]
public class CatTest_MsTest
{
    private readonly Cat _cat;
    private Cat _cat2;

    public CatTest_MsTest() => _cat = new Cat {Name = "Kissen"};

    [TestInitialize]
    public void Initialize()
    {
        _cat2 = new Cat {Name = "Mao"};
    }

    [TestMethod]
    [DataRow("Esso")]
    [DataRow("Figaro")]
    public void ChangeName_ShouldWork(string name)
    {
        _cat2.Name = name;
        _cat.Name = name;
        var actual = _cat.Name;
        var actual2 = _cat2.Name;
        Assert.AreEqual(name, actual);
        Assert.AreEqual(name, actual2);
    }

    [TestMethod]
    public void NameTest()
    {
        const string expected = "Kissen";
        const string expected2 = "Mao";
        var actual = _cat.Name;
        var actual2 = _cat2.Name;
        Assert.AreEqual(expected, actual);
        Assert.AreEqual(expected2, actual2);
        Assert.IsInstanceOfType(_cat, typeof(Cat));
    }
}