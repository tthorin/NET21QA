using Xunit;

namespace SRPClassLib.Tests;

public class FileHandlerTests
{
    private readonly FileHandler sut;
    public FileHandlerTests()
    {
        sut = new FileHandler();
    }
    [Fact]
    public void Load_FirstTest_ShouldFail()
    {
        const string expected = "Hello";
        var actual = sut.Load();
        
        Assert.Equal(expected,actual);
    }
}